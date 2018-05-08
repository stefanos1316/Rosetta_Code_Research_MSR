extern crate num;

use num::traits::One;
use std::ops::Mul;

fn pow<T>(mut base: T, mut exp: usize) -> T 
    where T: Clone + One + Mul<T, Output=T>
{
    if exp == 0 { return T::one() }
    while exp & 1 == 0 {
        base = base.clone() * base;
        exp >>= 1;
    }
    if exp == 1 { return base }
    let mut acc = base.clone();
 
    while exp > 1 {
        exp >>= 1;
        base = base.clone() * base;
        if exp & 1 == 1 {
            acc = acc * base.clone();
        }
    }
    acc
}


fn main() {

for i in 1..2000000000 {
	let c = i as f64;
    	let d = i as i64;
        let a: i64 = pow(2017+d,12);
        let b: f64 = pow(19.88 + c,12);
 }
}
