
fn main() {

for i in 0..10000000{
	let x  = format!("{}", i);
	let mut s: String = x.to_owned();
    	let borrowed_string: &str = "http%3A%2F%2Ffoo%20bar%2F";

    	s.push_str(borrowed_string);

   //let s = "this is a matching string";
    assert_eq!(s.find("string"), None);
    assert_eq!(s, s.replacen("string", "string", 6));
}
}

