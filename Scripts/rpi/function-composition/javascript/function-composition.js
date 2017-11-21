function compose(f, g) {
  return function(x) {
    return f(g(x));
  };
}


for (var i = 0; i < 100000000; ++i) {
  var id = compose(Math.sin, Math.asin);
  id(0.5); // 0.5
}
