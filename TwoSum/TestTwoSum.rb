require_relative "TwoSum"
require "test/unit"
 
class TestTwoSum < Test::Unit::TestCase
    
    def test_FindTerms_1

        temp = TwoSum.new
        sum = 3
        terms = [1,2]
        result = temp.FindTerms(sum, terms)
        assert_equal([1,2], result)
        assert_equal(sum, result[0] + result[1])

    end

    def test_FindTerms_2

        temp = TwoSum.new
        sum = 4
        terms = [3,1]
        result = temp.FindTerms(sum, terms)
        assert_equal([3,1], result)
        assert_equal(sum, result[0] + result[1])
    end

    def test_FindTerms_3

        temp = TwoSum.new
        sum = 15
        terms = [9, 7, 16, 18, 20, 21, 1, 8]
        result = temp.FindTerms(sum, terms)
        assert_equal([7,8], result)
        assert_equal(sum, result[0] + result[1])
    end

end