"""
function(ids(list), m), find the minimal unique ids removing m items from the ids

"""

def solution(ids, m):
    ids.sort()
    # https://stackoverflow.com/questions/23240969/python-count-repeated-elements-in-the-list
    d_ids = {i:ids.count(i) for i in ids}
    
    # sort by acending order by value
    # https://stackoverflow.com/questions/613183/how-do-i-sort-a-dictionary-by-value
    sd_ids = dict(sorted(d_ids.items(), key = lambda item: item[1]))
    d_len = len(d_ids)
    
    # iterate through dictionary and remove as many unique keys as possible
    for key in sd_ids:
        value = sd_ids[key]
        m = m - value
        if m == 0:
            return d_len - 1
        elif m < 0:
            return d_len
        else:
            d_len = d_len - 1
    
      
# main function with test cases
   
if __name__ == '__main__':
    t1 = [4,3,2,1,3,2,1,2,1,1,4,1,2,2,2,3,3]
    s1 = solution(t1, 7)
    print('Result = ' + str(s1))
    
    t2 = ["a","a","b"]
    s2 = solution(t2, 3)
    print('Result = ' + str(s2))