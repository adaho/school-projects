//Assignment 1, Ada Ho, CIS494, Tue/Thur 4:30pm
package com.ada.cis494;

import java.util.Scanner;

public class LoanManager {

	private static GenericLoan[] listOfLoans;
	private static int numberOfLoans;

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		listOfLoans = new GenericLoan[10];
		numberOfLoans = 0;
		showMenu();
	}

	private static void showMenu(){
		String userInput = "";
		double loanAmount = 0;
		int numOfYears = 0;
		int ficoScore = 0;

		Scanner s = new Scanner(System.in);

		do{
			System.out.print("Do you want to apply for a (A)uto loan or a (M)ortgage? ");
			userInput = s.nextLine();
			userInput = userInput.toUpperCase();

			if(userInput.equals("X"))
				break;

			System.out.print("Enter loan amount: ");
			loanAmount = Double.parseDouble(s.nextLine());
			System.out.print("Enter number of years: ");
			numOfYears = Integer.parseInt(s.nextLine());

			switch(userInput){
				case "M":
					System.out.print("Enter FICO score: ");
					ficoScore = Integer.parseInt(s.nextLine());

					if(ficoScore < 500){
						System.out.println("This application cannot be processed.");
						break;
					}

					MortgageLoan mortgageLoan = new MortgageLoan();
					mortgageLoan.setLoanAmount(loanAmount);
					mortgageLoan.setNumOfYears(numOfYears);
					mortgageLoan.setFicoScore(ficoScore);
					listOfLoans[numberOfLoans++] = mortgageLoan;
					System.out.printf("The total payment on this loan will be $" + "%1$.2f", mortgageLoan.totalPayment());
					System.out.println();
					break;
				case "A":
					AutoLoan autoLoan = new AutoLoan(numOfYears, loanAmount);
					listOfLoans[numberOfLoans++] = autoLoan;
					System.out.printf("The total payment on this loan will be %1$.2f", autoLoan.totalPayment());
					System.out.println();
					break;
			}
		} while (! userInput.equalsIgnoreCase("X"));

		printLoanList();
		s.close();
	}

	private static void printLoanList(){
		System.out.println("Following are the loans in the system.");

		for(int i = 0; i < numberOfLoans; i++){
			System.out.printf("Amount: $" + "%1$.2f", listOfLoans[i].getLoanAmount());

			if(listOfLoans[i] instanceof MortgageLoan){
				MortgageLoan tempMortgage = (MortgageLoan) listOfLoans[i];
				System.out.printf(", FICO: %1$s", tempMortgage.getFicoScore());
			}
			System.out.println();
		}
	}
}
