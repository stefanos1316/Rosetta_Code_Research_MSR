extern crate rand;
use std::thread;

fn main() {

    for _i in 0..1000000 {
        for word in "Enjoy Rosetta Code".split_whitespace() {
            let local_word = word.to_owned();
            let original_thread = std::thread::spawn(move || {
                thread::sleep(std::time::Duration::from_millis(1));
                println!("{} {}",_i, local_word);
            });
        let _ = original_thread.join();
        }
    }
    //thread::sleep(std::time::Duration::from_millis(1));
}

