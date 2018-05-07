typealias Modifier = (String)->String

func uppercase() -> Modifier {
    return { string in
        return string.uppercased()
    }
}

func removeLast() -> Modifier {
    return { string in
        return String(string.characters.dropLast())
    }
}

func addSuffix(suffix: String) -> Modifier {
    return { string in
        return string + suffix
    }
}

func compose(_ left: @escaping Modifier, _ right: @escaping Modifier) -> Modifier {
    return { string in
        left(right(string))
    }
}

for i in 0...1000000000 {
	let a = compose(compose(uppercase(), removeLast()), addSuffix(suffix: "Abc"))("IntitialValue")
}
