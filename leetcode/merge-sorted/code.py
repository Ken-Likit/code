x = m - 1
        y = n - 1
        t = m + n - 1
        
        while x >= 0 and y >= 0:
            if nums1[x] < nums2[y]:
                nums1[t] = nums2[y]
                y = y - 1
            else:
                nums1[t] = nums1[x]
                x = x - 1
            t = t - 1
        
        if y >= 0:
            nums1[:t+1] = nums2[:y+1]
        
        return nums1