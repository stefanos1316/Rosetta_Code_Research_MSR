extern crate urlparse;

use urlparse::urlparse;
use urlparse::GetQuery;

fn main() {

	for  i in 0..100000000 {

		let x  = format!("{}", i);
		let mut owned_string: String = x.to_owned();
    		let borrowed_string: &str = "http%3A%2F%2Ffoo%20bar%2F";

    		owned_string.push_str(borrowed_string);
		let url = urlparse(owned_string);
	}
}
