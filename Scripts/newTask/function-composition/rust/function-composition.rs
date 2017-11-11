
fn compose<'a,F,G,T,U,V>(f: F, g: G) -> Box<Fn(T) -> V + 'a>
    where F: Fn(U) -> V + 'a,
          G: Fn(T) -> U + 'a,
{
   Box::new(move |x| f(g(x)))
}

fn main() {
    let sin_asin = compose(sin(), asin());
    print!("{}",sin_asin(0.5));
}
