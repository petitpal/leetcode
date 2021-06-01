
class TwoSum

    # crappy implementation that just loops terms many times...
    def FindTerms(sum, terms)

        result = Array.new
        i = 0
        j = 0

        while i < terms.length()
            while j < terms.length()
                if i != j && terms[i] + terms[j] == sum
                    return [terms[i], terms[j]]
                end
                j += 1
            end
            i += 1
            j = 0
        end
        
        [nil,nil]
    end

end
