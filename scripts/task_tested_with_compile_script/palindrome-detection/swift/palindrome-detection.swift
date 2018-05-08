extension String {
   
    public func isPalindrome() -> Bool {
        var s = String(self.characters.filter { $0 != Character(" ") }).lowercased()
        return s == String(s.characters.reversed())
    }
    
}

for i in 0...200000000 {
 let data = "saippuakivikauppias" + String(i)
 data.isPalindrome()   // true
}
