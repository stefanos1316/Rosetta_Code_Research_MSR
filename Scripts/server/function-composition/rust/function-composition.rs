fn comp<F: 'static, Fin, Fout, G: 'static, Gout>(g: G, f: F) -> Box<Fn(Fin) -> Gout>
    where 
    F: Fn(Fin) -> Fout,
    G: Fn(Fout) -> Gout {
    Box::new(move |x| g(f(x)))
}

fn main(){

	for _i in 0..1000000000 {
		let inc = |x| x + 1;
    		let half = |x| x / 2;
   		assert!((comp(inc,half))(3) == 2)
	}
}
