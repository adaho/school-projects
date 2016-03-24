//Inclass 8, Ada Ho, CIS494, Tue/Thur 4:30pm
package com.adaho.cis494;

import javafx.application.Application;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.input.KeyEvent;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;
import javafx.scene.paint.Color;
import javafx.scene.paint.Paint;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Rectangle;


public class Main extends Application {

	Rectangle blueBox;
	Rectangle yellowBox;
	Rectangle redBox;
	Rectangle blackBox;
	Rectangle greenBox;
	BorderPane borderPane;
	VBox colorPane;
	Pane drawingPane;
	Circle dot;
	Scene scene;
	double xLocation;
	double yLocation;
	double xShift;
	double yShift;
	String currentColor;

	@Override
	public void start(Stage primaryStage) {
		try {
			createScene();
			primaryStage.setTitle("Etch a Color Sketch");
			
			scene.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
			primaryStage.setScene(scene);
			primaryStage.show();
			
			initializeDrawingOptions();
			drawingPane.requestFocus();
		} catch(Exception e) {
			e.printStackTrace();
		}
	}

	public Paint getPaintValue(){

		return Paint.valueOf(currentColor);
	}

	public void initializeDrawingOptions(){
		xShift = 7;
		yShift = 5;
		xLocation = 100;
		yLocation = 250;
		currentColor = "Black";
		dot = new Circle(xLocation, yLocation, 10, getPaintValue());
		drawingPane.getChildren().add(dot);
	}

	public void drawingPaneKeyPressedEvent(KeyEvent e){

		switch(e.getCode()){

		case UP:
			yLocation -= yShift;
			break;
		case DOWN:
			yLocation += yShift;
			break;
		case LEFT:
			xLocation -= xShift;
			break;
		case RIGHT:
			xLocation += xShift;
			break;
		}

		dot = new Circle(xLocation, yLocation, 10, getPaintValue());
		drawingPane.getChildren().add(dot);
	}

	public void createScene(){

		borderPane = new BorderPane();
		drawingPane = new Pane();
		drawingPane.setOnKeyPressed(e -> drawingPaneKeyPressedEvent(e));
		colorPane = new VBox();

		blueBox = new Rectangle();
		blueBox.setHeight(20);
		blueBox.setWidth(20);
		blueBox.setFill(Color.BLUE);
		blueBox.setOnMouseClicked(e-> {
			currentColor = "Blue";
			drawingPane.requestFocus();
		});

		yellowBox = new Rectangle();
		yellowBox.setHeight(20);
		yellowBox.setWidth(20);
		yellowBox.setFill(Color.YELLOW);
		yellowBox.setOnMouseClicked(e-> {
			currentColor = "Yellow";
			drawingPane.requestFocus();
		});

		redBox = new Rectangle();
		redBox.setHeight(20);
		redBox.setWidth(20);
		redBox.setFill(Color.RED);
		redBox.setOnMouseClicked(e-> {
			currentColor = "Red";
			drawingPane.requestFocus();
		});
		
		blackBox = new Rectangle();
		blackBox.setHeight(20);
		blackBox.setWidth(20);
		blackBox.setFill(Color.BLACK);
		blackBox.setOnMouseClicked(e-> {
			currentColor = "Black";
			drawingPane.requestFocus();
		});
		
		greenBox = new Rectangle();
		greenBox.setHeight(20);
		greenBox.setWidth(20);
		greenBox.setFill(Color.GREEN);
		greenBox.setOnMouseClicked(e-> {
			currentColor = "Green";
			drawingPane.requestFocus();
		});
		
		colorPane.getChildren().addAll(blueBox, yellowBox, redBox, blackBox, greenBox);
		borderPane.setLeft(colorPane);
		borderPane.setCenter(drawingPane);
		scene = new Scene(borderPane,700,700);
	}

	public static void main(String[] args) {
		launch(args);
	}
}
