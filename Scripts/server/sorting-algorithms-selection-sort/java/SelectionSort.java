public class SelectionSort {


private static volatile int r = 1;

public static int executeTask(int i) {

	int[] array = {16,93,-99,95,-96,-24,-53,-71,96,-66,-21,72,-12,-32,-96,62,-42,-50,49,53,-65,52,-25,-69,88,-43,60,66,-94,-69,53,-71,-17,-58,-30,32,-16,-94,-42,-86,59,-53,94,97,-12,15,65,-35,-12,-82,-82,48,-48,66,-42,-63,33,-49,41,-85,94,66,-60,60,-65,-73,-50,-9,-48,-3,15,-77,81,95,-93,83,-21,34,-78,-61,-22,-58,65,78,41,-7,-59,20,88,-38,-15,-69,42,97,-35,61,8,2,-22,-85};
	SelectionSort obj = new SelectionSort();
	obj.sort(array);
	
	return i + 1;
}

public static void main (String[] args){
	for (int i = 0; i < 1000000000; ++i) {
		r = executeTask(i + r);
	}
}

public static void sort(int[] nums){
	for(int currentPlace = 0;currentPlace<nums.length-1;currentPlace++){
		int smallest = Integer.MAX_VALUE;
		int smallestAt = currentPlace+1;
		for(int check = currentPlace; check<nums.length;check++){
			if(nums[check]<smallest){
				smallestAt = check;
				smallest = nums[check];
			}
		}
		int temp = nums[currentPlace];
		nums[currentPlace] = nums[smallestAt];
		nums[smallestAt] = temp;
	}
}

}
