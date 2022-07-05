def solutions(S, T):
    nS = []
    nT = []
    
    for letter in S:
        if letter.isdigit() == True:
            dig = int(letter)
            #Does not account for numbers greater than 9, have temp string. Then add code that looks for next spot
            while dig > 0:
                nS.append('?')
                dig -= 1
        else:
            nS.append(letter)
             
    for letter in T:
        if letter.isdigit() == True:
            dig = int(letter)
            while dig > 0:
                nT.append('?')
                dig -= 1
        else:
            nT.append(letter)
            
    #two letter functions are the same, use function to do this task
    
    lS = len(nS)
    lT = len(nT)
    
    if lS != lT:
        return False
    
    length = 0
    while lS > length:
        if nS[length] == nT[length] or nS[length] == '?' or nT[length] == '?':
            length += 1
        else:
            return False
        
    return True
        