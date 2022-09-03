public static int  maxNumOfChocolates(int[] choco)
	{
		int  answer = 0;
		int zero_start = 0;
		int one_start = 0;
		
	
		int i = 0;
		while (i < choco.length) {
			int temp = choco[i];
			if (temp == 0) {
				i++;
			}
			else {
				zero_start+=temp;
				i+=2;
			}
		}

		int j = 1;
		while (j < choco.length) {
			int temp = choco[j];
			if (temp == 0) {
				j++;
			}
			else {
				one_start+=temp;
				j+=2;
			}
		}

		if(zero_start > one_start) {
			answer = zero_start;
		}
		else {
			answer = one_start;
		}
		
		return answer;
	}

 1 2 13 0 24 65