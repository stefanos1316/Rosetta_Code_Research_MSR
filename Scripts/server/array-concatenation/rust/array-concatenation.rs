fn main() {
	for i in 0..2000000000 {
   		let a_vec: Vec<i32> = vec![1+i, 2-i, 3+i, 4-i, 5+i];
   		let b_vec: Vec<i32> = vec![6+i, 7-i, 8+i, 9-i, 10+i];
    		let _c_vec = concatenate_arrays::<i32>(a_vec.as_slice(), b_vec.as_slice());
	}
}

fn concatenate_arrays<T: Clone>(x: &[T], y: &[T]) -> Vec<T> {
    let mut concat: Vec<T> = vec![x[0].clone(); x.len()];

    concat.clone_from_slice(x);
    concat.extend_from_slice(y);

    concat
}
