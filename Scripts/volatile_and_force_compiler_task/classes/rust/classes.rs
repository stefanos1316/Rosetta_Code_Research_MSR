
fn main() {
    struct MyClass {
	variable: u32
  }

    impl MyClass {
        pub fn new() -> MyClass {
            MyClass { variable: 19022 }
        }
        pub fn someMethod(&self, i: u32) -> u32 {
            return self.variable + i
        }
    }

for i in 0..2100000000{
    let my_class = MyClass::new();
     my_class.someMethod(i);
}
}
