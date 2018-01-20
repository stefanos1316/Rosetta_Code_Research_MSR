for i in 0..10000000

str = "this is a matching tring" + i.to_s
    if str =~ /string$/
    end
    str.sub(/string/, 'istyfied') 
end

