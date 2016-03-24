//Assignment 1, Ada Ho, CIS494, Tue/Thur 4:30pm
package com.ada.cis494;

public class AutoLoan extends GenericLoan{

	public AutoLoan(int years, double amount){
		numOfYears = years;
		loanAmount = amount;
		annualInterestRate = 5.0;
	}

	@Override
	public double monthlyPayment() {
		// TODO Auto-generated method stub
		double monthlyInterestRate = annualInterestRate / 1200;
		double monthlyPayment = loanAmount * monthlyInterestRate / (1 - (Math.pow(1 / (1 + monthlyInterestRate), numOfYears * 12)));
		return monthlyPayment;
	}

	@Override
	public double totalPayment() {
		// TODO Auto-generated method stub
		double totalPayment = monthlyPayment() * (12 * numOfYears);
		return totalPayment;
	}

}
