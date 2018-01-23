Module VBModule
   
      'Public Module GlobalVariables
    	Public aVar As Double = 0
     ' End Module

    Sub Main()

	For value As Integer = 0 To 100  
        	
		aVar += 1	
	
		integration_rectagle("cube",0.0,1.0,100.0,0.0) 
		integration_rectagle("cube",0.0,1.0,100.0,0.5) 
		integration_rectagle("cube",0.0,1.0,100.0,1.0) 
		integration_trapezoid("cube",0.0,1.0,100.0) 
		integration_simpsons("cube",0.0,1.0,100.0) 

		integration_rectagle("reciprocal",1.0,100.0,1000.0,0.0) 
		integration_rectagle("reciprocal",1.0,100.0,1000.0,0.5) 
		integration_rectagle("reciprocal",1.0,100.0,1000.0,1.0) 
		integration_trapezoid("reciprocal",1.0,100.0,1000.0) 
		integration_simpsons("reciprocal",1.0,100.0,1000.0) 

		integration_rectagle("identity",0.0,5000.0,5000000.0,0.0) 
		integration_rectagle("identity",0.0,5000.0,5000000.0,0.5) 
		integration_rectagle("identity",0.0,5000.0,5000000.0,1.0) 
		integration_trapezoid("identity",0.0,5000.0,5000000.0) 
		integration_simpsons("identity",0.0,5000.0,5000000.0) 

		integration_rectagle("identity",0.0,6000.0,6000000.0,0.0) 
		integration_rectagle("identity",0.0,6000.0,6000000.0,0.5) 
		integration_rectagle("identity",0.0,6000.0,6000000.0,1.0) 
		integration_trapezoid("identity",0.0,6000.0,6000000.0) 
		integration_simpsons("identity",0.0,6000.0,6000000.0) 
	Next 

    End Sub
   
    Public Function cube(x as Double) As Double
        return x*x*x+aVar
	End Function

    Public Function reciprocal(x as Double) As Double
        return 1/(x+aVar)
	End Function
  
     Public Function identity(x as Double) As Double
        return (x+aVar)
	End Function
	
	 Public Function integration_rectagle(func as String, a as Double, b as Double, n as Double, k as Double) as Double
	 
	    Dim h as Double = (b - a) / n
        Dim sum as Double = 0
        Dim i as Double = 0
        
        while i < b
            if String.Compare(func,"cube") then
                sum += cube(i - h * (1 - k))
            end if

            if String.Compare(func,"reciprocal") then 
                sum += reciprocal(i - h * (1 - k))
            end if 

            if String.Compare(func,"identity") then
                sum += identity(i - h * (1 - k))
            end if
            
            i += b/n
        end while
        
        sum *= h
        return sum
	End Function
	
	 Public Function integration_trapezoid(func as String, a as Double, b as Double, n as Double) as Double
	 
	    Dim h as Double = (b - a) / n
        Dim sum as Double = 0
        Dim i as Double = 0
        
        while i < b
            if String.Compare(func,"cube") then
                if i < (b - 1.0) then
                    sum += cube(i) + cube(i + 1)
                else 
                    sum += cube(i) + cube(i + 1 - b)
                end if
            end if

            if String.Compare(func,"reciprocal") then
                if i < (b - 1.0) then
                    sum += reciprocal(i) + reciprocal(i + 1)
                else 
                    sum += reciprocal(i) + reciprocal(i + 1 - b)
                end if
            end if

            if String.Compare(func,"identity") then
                if i < (b - 1.0) then
                    sum += identity(i) + identity(i + 1)
                else 
                    sum += identity(i) + identity(i + 1 - b)
                end if
            end if
            
            i += b/n
        end while
        
        sum *= h/2.0
        return sum
	End Function
	
	Public Function integration_simpsons(func as String, a as Double, b as Double, n as Double) as Double
	 
	    Dim h as Double = (b - a) / n
        Dim sum as Double = 0
        Dim i as Double = 0
        
        while i < b
            if String.Compare(func,"cube") then
                if i < (b - 1.0) then
                    sum += cube(i) + (4 * cube(i - (h / 2))) + cube(i + 1)
                else 
                    sum += cube(i) + (4 * cube(i - (h / 2))) + cube(i + 1 - b)
                end if
            end if

            if String.Compare(func,"reciprocal") then
                if i < (b - 1.0) then
                    sum += reciprocal(i) + (4 * reciprocal(i - (h / 2))) + reciprocal(i + 1)
                else 
                    sum += reciprocal(i) + (4 * reciprocal(i - (h / 2))) + reciprocal(i + 1 - b)
                end if
            end if

            if String.Compare(func,"identity") then
                if i < (b - 1.0) then
                    sum += identity(i) + (4 * identity(i - (h / 2))) + identity(i + 1)
                else 
                    sum += identity(i) + (4 * identity(i - (h / 2))) + identity(i + 1 - b)
                end if
            end if
            
            i += b/n
        end while
        
        sum *= h/6.0
        return sum
	End Function

End Module
