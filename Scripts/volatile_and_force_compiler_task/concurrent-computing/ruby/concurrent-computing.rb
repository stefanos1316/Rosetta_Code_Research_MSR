
(0..1000000).each do |i|
    %w{Enjoy Rosetta Code}.map do |x|
        Thread.new do
            sleep 0.001
            puts "#{i} #{x}"
        end
    end.each do |t|
    t.join
    end
end
