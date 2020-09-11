package tvz;

import java.util.Calendar;

/**
 * A class used for getting current date.
 * 
 * @author Bruno
 * @version 1.0, 11 Sep 2020
 *
 */
public class GetCurrentDateTimeExample {
	/**
	 * Main
	 * 
	 * @param args Arguments
	 */
	public static void main(String[] args) {

		Calendar now = Calendar.getInstance();

		System.out.println("Current Year is : " + now.get(Calendar.YEAR));
		System.out.println("Current Month is : " + (now.get(Calendar.MONTH) + 1));
		System.out.println("Current Date is : " + now.get(Calendar.DATE));

		System.out.println("Current Hour in 12 hour format is : " + now.get(Calendar.HOUR));
		System.out.println("Current Hour in 24 hour format is : " + now.get(Calendar.HOUR_OF_DAY));
		System.out.println("Current Minute is : " + now.get(Calendar.MINUTE));
		System.out.println("Current Second is : " + now.get(Calendar.SECOND));
		System.out.println("Current Millisecond is : " + now.get(Calendar.MILLISECOND));

		System.out.println("Current full date time is : " + (now.get(Calendar.MONTH) + 1) + "-" + now.get(Calendar.DATE)
				+ "-" + now.get(Calendar.YEAR) + " " + now.get(Calendar.HOUR_OF_DAY) + ":" + now.get(Calendar.MINUTE)
				+ ":" + now.get(Calendar.SECOND) + "." + now.get(Calendar.MILLISECOND));
	}
}

