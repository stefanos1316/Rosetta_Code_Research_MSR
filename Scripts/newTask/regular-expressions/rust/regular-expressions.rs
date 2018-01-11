
fn main() {

for i in 0..10000000{

    let s = "this is a matching string";
    assert_eq!(s.find("string"), Some(19));
    assert_eq!(s, s.replacen("string", "string", 6));
}
}

