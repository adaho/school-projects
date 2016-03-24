//Assignment 2, Ada Ho, CIS494, Tue/Thur 4:30pm
package com.adaho.cis494.assignment2;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.NoSuchElementException;
import java.util.Scanner;

import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.scene.text.Font;


public class Main extends Application {
	@Override
	public void start(Stage primaryStage) {
		try {
			VBox pane = loadUsersFromFile();
			Scene scene = new Scene(pane, 300, 200);
			primaryStage.setScene(scene);
			primaryStage.setTitle("List of Users");
			primaryStage.show();

			//BorderPane root = new BorderPane();
			//scene.getStylesheets().add(getClass().getResource("application.css").toExternalForm());

		} catch(Exception e) {
			e.printStackTrace();
		}
	}

	public static void main(String[] args) {
		launch(args);
	}

	public HBox buildTableLine(String name, String id, String url){

		GridPane recordPane = new GridPane();
		recordPane.setPadding(new Insets(15, 15, 15, 15));
		recordPane.setHgap(50);
		recordPane.setVgap(15);
		Font standardFont = new Font("Times New Roman", 16);

		Label nameLabel = new Label("Name:");
		nameLabel.setFont(standardFont);

		Label nameValueLabel = new Label();
		nameValueLabel.setText(name);
		nameValueLabel.setFont(standardFont);

		Label idLabel = new Label("ID:");
		idLabel.setFont(standardFont);

		Label idValueLabel = new Label();
		idValueLabel.setText(id);
		idValueLabel.setFont(standardFont);

		Image image = new Image(url);
		ImageView imageView = new ImageView(image);
		imageView.setFitHeight(80);
		imageView.setFitWidth(50);

		recordPane.add(nameLabel, 0, 0);
		recordPane.add(nameValueLabel, 1, 0);
		recordPane.add(idLabel, 0, 1);
		recordPane.add(idValueLabel, 1, 1);

		HBox outputPane = new HBox();
		outputPane.getChildren().add(recordPane);
		outputPane.getChildren().add(imageView);

		return outputPane;
	}

	public HBox processLine(String line){

		String[] userAttributes;
		userAttributes = line.split(",");

		String name;
		String id;
		String url;

		name = userAttributes[0];
		id = userAttributes[1];
		url = userAttributes[2];

		HBox linePane;
		linePane = buildTableLine(name, id, url);
		return linePane;
	}

	public VBox loadUsersFromFile(){

		String inputLine;
		VBox pane = new VBox();

		try(Scanner inputFile = new Scanner(new File("Users.txt"))){

			while(inputFile.hasNext()){
				inputLine = inputFile.nextLine();
				HBox tmpHBox;
				tmpHBox = processLine(inputLine);
				pane.getChildren().add(tmpHBox);
			}
		}
		catch(FileNotFoundException fnf){
			System.out.println("File not found...");
		}
		catch(NoSuchElementException Variable){
			System.out.println("No such element...");
		}

		return pane;
	}
}
