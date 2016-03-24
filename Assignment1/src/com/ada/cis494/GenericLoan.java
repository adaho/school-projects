//Assignment 1, Ada Ho, CIS494, Tue/Thur 4:30pm
package com.ada.cis494;

public abstract class GenericLoan {

	protected int numOfYears;
	protected double annualInterestRate;
	protected double loanAmount;

	public int getNumOfYears() {
		return numOfYears;
	}
	public void setNumOfYears(int numOfYears) {
		this.numOfYears = numOfYears;
	}
	public double getLoanAmount() {
		return loanAmount;
	}
	public void setLoanAmount(double loanAmount) {
		this.loanAmount = loanAmount;
	}

	public abstract double monthlyPayment();

	public abstract double totalPayment();
}
