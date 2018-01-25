import Foundation
import Dispatch

for i in 0...1000000 {
    let myList = ["Enjoy", "Rosetta", "Code"]
    let myGroup = DispatchGroup()
    for word in myList {
        myGroup.enter()
        DispatchQueue.main.async {
            print(String(i) + " " + word)
            myGroup.leave()
        }
    }
    //sleep(0.001)
    myGroup.notify(queue: .main) {
        print("Finished all requests.")
        exit(0)
    }
}

dispatchMain()
