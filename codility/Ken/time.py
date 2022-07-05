def solution(S, T):
    Sl = S.split(":")
    Tl = T.split(":")
    #checks unique letters 
    #Su = ''.join(Sl)
    Tl[0] = int(Tl[0])
    Tl[1] = int(Tl[1])
    Tl[2] = int(Tl[2])
    Sl[0] = int(Sl[0])
    Sl[1] = int(Sl[1])
    Sl[2] = int(Sl[2])
    Cl = Sl
    special = 0
    while Tl != Cl:
        Com = ''.join(str(e) for e in Cl)
        uni = ''.join(set(Com))
        if checkNum(Cl) == True and '0' not in uni: 
            uni = uni + "0"
        if len(uni) <= 2:
            special += 1
        if Cl[2] == 59:
            Cl[2] = 00
            if Cl[1] == 59:
                Cl[1] = 00
                if Cl[0] == 23:
                    Cl[0] = 00
                else:
                    Cl[0] += 1
            else:
                Cl[1] += 1
        else:         
            Cl[2] = Cl[2] + 1
        
    Com1 = ''.join(str(e) for e in Tl)
    uni1 = ''.join(set(Com1))
    if checkNum(Tl) == True and '0' not in uni1: 
            uni1 = uni1 + "0"
    if len(uni1) <= 2:
        special += 1
    
    return(special)

def checkNum(list):
    if list[0] < 10 or list[1] < 10 or list[2] < 10:
        return True
    else:
        return False

