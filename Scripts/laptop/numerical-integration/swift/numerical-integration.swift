func integral_rectagle(_ function: String, _ a: Float, _ b: Float, _ n: Float, _ k: Float) {

    let h = (b - a) / n
    var sum = Float(0)
    var i = Float(0)
    while i < b {
        if function == "cube" {
            sum += cube(i - h * (1 - k))
        }

        if function == "reciprocal" {
            sum += reciprocal(i - h * (1 - k))
        }

        if function == "identity" {
            sum += identity(i - h * (1 - k))
        }
        i += b/n
    }
    sum *= h
}

func integral_trapezoid(_ function: String, _ a: Float, _ b: Float, _ n: Float) {

    let h = (b - a) / n
    var sum = Float(0)
    var i = Float(0)
    while i < b {
        if function == "cube" {
            if i < (b - 1) {
                sum += cube(i) + cube(i + 1)
            } else {
                sum += cube(i) + cube(i + 1 - b)
            }
        }

        if function == "reciprocal" {
            if i < (b - 1) {
                sum += reciprocal(i) + reciprocal(i + 1)
            } else {
                sum += reciprocal(i) + reciprocal(i + 1 - b)
            }
        }

         if function == "identity" {
            if i < (b - 1) {
                sum += identity(i) + identity(i + 1)
            } else {
                sum += identity(i) + identity(i + 1 - b)
            }
        }
        i += b/n
    }
    sum *= h/2
}

 func integral_simpsons(_ function: String, _ a: Float, _ b: Float, _ n: Float) {

    let h = (b - a) / n
    var sum = Float(0)
    var i = Float(0)
    while i < b {
        if function == "cube" {
            if i < (b - 1) {
                sum += cube(i) + (4 * cube(i - (h / 2))) + cube(i + 1)
            } else {
                sum += cube(i) + (4 * cube(i - (h / 2))) + cube(i + 1 - b)
            }
        }

        if function == "reciprocal" {
            if i < (b - 1) {
                sum += reciprocal(i) + (4 * reciprocal(i - (h / 2))) + reciprocal(i + 1)
            } else {
                sum += reciprocal(i) + (4 * reciprocal(i - (h / 2))) + reciprocal(i + 1 - b)
            }
        }

         if function == "identity" {
            if i < (b - 1) {
                sum += identity(i) + (4 * identity(i - (h / 2))) + identity(i + 1)
            } else {
                sum += identity(i) + (4 * identity(i - (h / 2))) + identity(i + 1 - b)
            }
        }
        i += b/n
    }
    sum *= h/2
}

func cube(_ x: Float) -> Float {
    return x*x*x+Float(aVar)
}

func reciprocal(_ x: Float) -> Float {
    return 1/(x+Float(aVar))
}

func identity(_ x: Float) -> Float {
    return (x+Float(aVar))
}

 var aVar = 0

for aVar in 0...100 {
    integral_rectagle("cube", 0.0, 1.0, 100.0, 0.0)
    integral_rectagle("cube", 0.0, 1.0, 100.0, 0.5)
    integral_rectagle("cube", 0.0, 1.0, 100.0, 1.0)
    integral_trapezoid("cube", 0.0, 1.0, 100.0)
    integral_simpsons("cube", 0.0, 1.0, 100.0)

    integral_rectagle("reciprocal", 1.0, 100.0, 1000.0, 0.0)
    integral_rectagle("reciprocal", 1.0, 100.0, 1000.0, 0.5)
    integral_rectagle("reciprocal", 1.0, 100.0, 1000.0, 1.0)
    integral_trapezoid("reciprocal", 1.0, 100.0, 1000.0)
    integral_simpsons("reciprocal", 1.0, 100.0, 1000.0)

    integral_rectagle("identity", 0.0, 5000.0, 5000000.0, 0.0)
    integral_rectagle("identity", 0.0, 5000.0, 5000000.0, 0.5)
    integral_rectagle("identity", 0.0, 5000.0, 5000000.0, 1.0)
    integral_trapezoid("identity", 0.0, 5000.0, 5000000.0)
    integral_simpsons("identity", 0.0, 5000.0, 5000000.0)

    integral_rectagle("identity", 0.0, 6000.0, 6000000.0, 0.0)
    integral_rectagle("identity", 0.0, 6000.0, 6000000.0, 0.5)
    integral_rectagle("identity", 0.0, 6000.0, 6000000.0, 1.0)
    integral_trapezoid("identity", 0.0, 6000.0, 6000000.0)
    integral_simpsons("identity", 0.0, 6000.0, 6000000.0)
_=aVar
}
