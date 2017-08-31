extern crate rand;
use std::thread;

fn main() {
    let data: Vec<String> = (vec![std::string::String::"Enjoy", std::string::String::"Rosetta", std::string::String::"Code"]);
    for  i in 0..2 {
        for j in data {
            //let local_word = word.to_owned();
            let original_thread = std::thread::spawn(move || {
                thread::sleep(std::time::Duration::from_millis(1));
                println!("{}", j);
            });
        let _ = original_thread.join();
        }
    }

}

