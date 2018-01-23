extern crate rand;
use std::thread;
use rand::thread_rng;
use rand::distributions::{Range, IndependentSample};

fn main() {
    let mut rng = thread_rng();
    //println!("Yes I have entered here!!!");
    //let rng_range = Range::new(0u32, 100);
    for word in "Enjoy Rosetta Code".split_whitespace() {
        //let snooze_time = rng_range.ind_sample(&mut rng);
        let local_word = word.to_owned();
        std::thread::spawn(move || {
            thread::sleep(1);
            println!("{}", local_word);
        });
    }
    thread::sleep(1);
}
