//Assignment 1, Ada Ho, CIS494, Tue/Thur 4:30pm
package com.ada.cis494;

public class MortgageLoan extends GenericLoan{

	protected int ficoScore;

	public MortgageLoan(){
		super();
		ficoScore = 600;
	}

	public int getFicoScore() {
		return ficoScore;
	}

	public void setFicoScore(int ficoScore) {
		this.ficoScore = ficoScore;
	}

	@Override
	public double monthlyPayment() {
		// TODO Auto-generated method stub
		if(ficoScore < 700){
			annualInterestRate = 6.5;
		}
		else{
			annualInterestRate = 4.0;
		}

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
