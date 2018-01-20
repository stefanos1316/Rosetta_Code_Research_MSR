#![allow(dead_code)]

fn integral_rectagle<F>(f: F, range: std::ops::Range<f64>, n_steps: u32, k_left_mid_right: f64) -> f64
    where F: Fn(f64) -> f64
{
    let step_size = (range.end - range.start)/n_steps as f64;

    let mut integral = f(range.start) + f(range.end);
    let mut pos = range.start + step_size;
    while pos < range.end {
        let step_size = step_size as f64; 
        let k_left_mid_right = k_left_mid_right as f64;
        let part = step_size * ( 1.0 - k_left_mid_right) ;
        integral += f(pos) - part;
        pos += step_size;
    }
    integral * step_size
}

fn integral_trapezoid<F>(f: F, range: std::ops::Range<f64>, n_steps: u32) -> f64
    where F: Fn(f64) -> f64
{
    let step_size = (range.end - range.start)/n_steps as f64;

    let mut integral = f(range.start) + f(range.end)/2.;
    let mut pos = range.start + step_size;
    while pos < range.end {
        integral += f(pos);
        pos += step_size;
    }
    integral * step_size
}

fn integral_simpsons<F>(f: F, range: std::ops::Range<f64>, n_steps: u32) -> f64
    where F: Fn(f64) -> f64
{
    let step_size = (range.end - range.start)/n_steps as f64;

    let mut integral = f(range.start) + f(range.end)/6.;
    let mut pos = range.start + step_size;
    while pos < range.end {
        integral += f(pos) + (4. * f(pos - (step_size / 2.))) + f(pos + 1.);
        pos += step_size;
    }
    integral * step_size
}

fn main() {

for i in 0..1000 {

   let A_Var = i as f64; 	

    integral_rectagle(|x| x.powi(3) + A_Var, 0.0..1.0, 100, 0.);
    integral_rectagle(|x| x.powi(3) + A_Var, 0.0..1.0, 100, 0.5);
    integral_rectagle(|x| x.powi(3) + A_Var, 0.0..1.0, 100, 1.);
    integral_trapezoid(|x| x.powi(3) + A_Var, 0.0..1.0, 100);
    integral_simpsons(|x| x.powi(3) + A_Var, 0.0..1.0, 100);

    integral_rectagle(|x| 1.0/(x + A_Var), 1.0..100.0, 1000, 0.);
    integral_rectagle(|x| 1.0/(x + A_Var), 1.0..100.0, 1000, 0.5);
    integral_rectagle(|x| 1.0/(x + A_Var), 1.0..100.0, 1000, 1.);
    integral_trapezoid(|x| 1.0/(x + A_Var), 1.0..100.0, 1000);
    integral_simpsons(|x| 1.0/(x + A_Var), 1.0..100.0, 1000);

    integral_rectagle(|x| x + A_Var, 0.0..5000.0, 5_000_000, 0.);
    integral_rectagle(|x| x + A_Var, 0.0..5000.0, 5_000_000,0.5);
    integral_rectagle(|x| x + A_Var, 0.0..5000.0, 5_000_000,1.);
    integral_trapezoid(|x| x + A_Var, 0.0..5000.0, 5_000_000);
    integral_simpsons(|x| x + A_Var, 0.0..5000.0, 5_000_000);

    integral_rectagle(|x| x + A_Var, 0.0..6000.0, 6_000_000, 0.);
    integral_rectagle(|x| x + A_Var, 0.0..6000.0, 6_000_000,0.5);
    integral_rectagle(|x| x + A_Var, 0.0..6000.0, 6_000_000,1.);
    integral_trapezoid(|x| x + A_Var, 0.0..6000.0, 6_000_000);
    integral_simpsons(|x| x + A_Var, 0.0..6000.0, 6_000_000);
    let _ = i;
}

}
