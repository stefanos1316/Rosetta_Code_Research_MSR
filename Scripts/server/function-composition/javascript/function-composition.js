function compose(f, g) {
  return function(x) {
    return f(g(x));
  };
}

var id2
for (var i = 0; i < 1000000000; ++i) {
  var id = compose(Math.sin, Math.asin);
  id2 = id(0.5); // 0.5
}
