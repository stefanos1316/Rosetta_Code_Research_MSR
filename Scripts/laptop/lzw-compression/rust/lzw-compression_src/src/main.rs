extern crate lzw;

use lzw::{LsbWriter, Encoder, Decoder};


fn main() {

for i in 0..1000000 {
	let size = 8;
    let data = b"TOBEORNOTTOBEORTOBEORNOT";
    let mut compressed = vec![];
    {
        let mut enc = Encoder::new(LsbWriter::new(&mut compressed), size).unwrap();
        enc.encode_bytes(data).unwrap();
    }
    let mut decoder = Decoder::new(lzw::LsbReader::new(),8);

    for i in compressed {
        decoder.decode_bytes(&[i]);
    }
}
}
