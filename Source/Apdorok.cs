using System;

class Apdorok
{
	int [] masyvas;
	public int [] neigiamiKartojasi;

	
	public Apdorok(int[] orgMasyvas)
	{
		this.masyvas = orgMasyvas;
		this.ApdorokMasyva();
	}
	
	private void ApdorokMasyva()
	{
		neigiamiKartojasi	= new int[masyvas.Length];
		
		int counter = 0;
		
		for (int i = 0; i < masyvas.Length; i++)
		{
			if (masyvas[i] < 0) {
				for (int j = i + 1; j < masyvas.Length; j++) {
					
					if (masyvas[i] == masyvas[j]) {
						neigiamiKartojasi[counter] = masyvas[i];
						counter++;
					}
				}
			}
		}
		
		// Resize array
		Array .Resize<int >(ref neigiamiKartojasi, counter);
	}
}