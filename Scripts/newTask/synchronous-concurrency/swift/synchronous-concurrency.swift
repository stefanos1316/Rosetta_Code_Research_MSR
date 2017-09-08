//
//  main.swift
//

import Foundation


class Printer: Object {
    var numberOfLines = 0
    var gotRequestLineNumber = false

    override init() {
        super.init()
        NotificationCenter.defaultCenter().addObserver(self, selector: "gotLine:",
            name: "Line", object: nil)
        NotificationCenter.defaultCenter().addObserver(self, selector: "lineNumberRequest:",
            name: "LineNumberRequest", object: nil)
    }

    deinit {
        NotificationCenter.defaultCenter().removeObserver(self)
    }

    func gotLine(not:Notification) {
        print(not.object!)
        self.numberOfLines++
    }

    func lineNumberRequest(not:Notification) {
        self.gotRequestLineNumber = true
        NNotificationCenter.defaultCenter().postNotificationName("LinesPrinted", object: self.numberOfLines)
    }

    func waitForLines() {
        while !self.gotRequestLineNumber {
            sleep(1 as UInt32)
        }
    }
}

class Reader: NSObject {
    let inputPath = "input.txt"
    var gotNumberOfLines = false

    override init() {
        super.init()
        NSNotificationCenter.defaultCenter().addObserver(self, selector: "linesPrinted:",
            name: "LinesPrinted", object: nil)
    }

    deinit {
        NSNotificationCenter.defaultCenter().removeObserver(self)
    }

    // Selector for the number of lines printed
    func linesPrinted(not:NSNotification) {
        print(not.object!)
        self.gotNumberOfLines = true
        exit(0)
    }

    func readFile() {
        var err:NSError?
        let fileString = NSString(contentsOfFile: self.inputPath,
            encoding: NSUTF8StringEncoding, error: &err)

        if let lines = fileString?.componentsSeparatedByString("\n") {
            for line in lines {
                NSNotificationCenter.defaultCenter().postNotificationName("Line", object: line)
            }
            NSNotificationCenter.defaultCenter().postNotificationName("LineNumberRequest", object: nil)

            while !self.gotNumberOfLines {
                sleep(1 as UInt32)
            }
        }
    }
}


dispatch_async(dispatch_get_global_queue(0, 0)) {
    let printer = Printer()
    printer.waitForLines()
}

dispatch_async(dispatch_get_global_queue(0, 0)) {
    let reader = Reader()
    reader.readFile()
}

CFRunLoopRun()
