extern crate urlparse;

use urlparse::urlparse;
use urlparse::GetQuery;

fn main() {

	for  i in 0..10000000 {
		let url = urlparse("http%3A%2F%2Ffoo%20bar%2F");
		//println!("{:?}", url);
		//let query = url.get_parsed_query().unwrap();
		//assert_eq!(url.scheme, "http");
		//assert_eq!(query.get_first_from_str("col").unwrap(), "println!(\"TEST!\")");
	}
}
