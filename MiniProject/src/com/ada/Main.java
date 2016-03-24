//Midterm 1: Mini Project, Ada Ho, CIS494, Tue/Thur 4:30pm
package com.ada;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.NoSuchElementException;
import java.util.Scanner;

import javafx.application.Application;
import javafx.application.Platform;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.Menu;
import javafx.scene.control.MenuBar;
import javafx.scene.control.MenuItem;
import javafx.scene.control.Separator;
import javafx.scene.control.SeparatorMenuItem;
import javafx.scene.control.TextArea;
import javafx.scene.control.ToolBar;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.VBox;


public class Main extends Application {

	BorderPane borderPane;
	VBox topContainer;
	Scene scene;
	MenuBar menuBar;
	Menu fileMenu;
	Menu editMenu;
	MenuItem save;
	MenuItem load;
	MenuItem exit;
	MenuItem clear;
	MenuItem cut;
	MenuItem copy;
	MenuItem paste;
	TextArea textArea;
	ToolBar toolBar;
	Button clearButton;
	Button saveButton;
	Button cutButton;
	Button copyButton;
	Button pasteButton;
	CheckBox wrapCheckBox;

	@Override
	public void start(Stage primaryStage) {
		try {
			//BorderPane root = new BorderPane();
			//Scene scene = new Scene(root,400,400);
			menuFunctions();
			toolbarFunctions();
			topContainer = new VBox();
			topContainer.getChildren().add(menuBar);
			topContainer.getChildren().add(toolBar);
			borderPane.setTop(topContainer);

			primaryStage.setTitle("Scratch Pad");
			scene.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
			primaryStage.setScene(scene);
			primaryStage.show();
		} catch(Exception e) {
			e.printStackTrace();
		}
	}

	public void menuFunctions(){
		borderPane = new BorderPane();
		textArea = new TextArea();
		menuBar = new MenuBar();

		//File Menu and MenuItems; instantiating variables and assigning actions to MenuItems
		fileMenu = new Menu("File");
		save = new MenuItem("Save");
		load = new MenuItem("Load");
		exit = new MenuItem("Exit");

		save.setOnAction(e-> saveFile());
		load.setOnAction(e-> loadFile());
		exit.setOnAction(e-> Platform.exit());

		//Edit Menu and MenuItems; instantiating variables and assigning actions to MenuItems
		editMenu = new Menu("Edit");
		clear = new MenuItem("Clear");
		cut = new MenuItem("Cut");
		copy = new MenuItem("Copy");
		paste = new MenuItem("Paste");

		clear.setOnAction(e-> textArea.clear());
		cut.setOnAction(e-> textArea.cut());
		copy.setOnAction(e-> textArea.copy());
		paste.setOnAction(e-> textArea.paste());

		//Adding MenuItems to the appropriate Menus, then adding Menus to the MenuBar
		fileMenu.getItems().addAll(save, load, new SeparatorMenuItem(), exit);
		editMenu.getItems().addAll(clear, cut, copy, paste);
		menuBar.getMenus().addAll(fileMenu, editMenu);

		borderPane.setCenter(textArea);
		scene = new Scene(borderPane,400,400);
	}

	public void toolbarFunctions(){ //instantiate button variables and adding buttons to the toolbar
		toolBar = new ToolBar();
		clearButton = new Button("Clear");
		saveButton = new Button("Save");
		cutButton = new Button("Cut");
		copyButton = new Button("Copy");
		pasteButton = new Button("Paste");
		wrapCheckBox = new CheckBox("Wrap");

		setActionHandlers();

		toolBar.getItems().add(clearButton);
		toolBar.getItems().add(saveButton);
		toolBar.getItems().add(new Separator());
		toolBar.getItems().add(cutButton);
		toolBar.getItems().add(copyButton);
		toolBar.getItems().add(pasteButton);
		toolBar.getItems().add(new Separator());
		toolBar.getItems().add(wrapCheckBox);
	}

	public void clearAction(){
		textArea.clear();
	}

	public void saveAction(){
		saveFile();
	}

	public void cutAction(){
		textArea.cut();
	}

	public void copyAction(){
		textArea.copy();
	}

	public void pasteAction(){
		textArea.paste();
	}

	public void wrapAction(){
		
		if(wrapCheckBox.isSelected()){
			textArea.setWrapText(true);
		}
		else{
			textArea.setWrapText(false);
		}
	}

	public void setActionHandlers(){
		//assigning event handlers for every button (and checkbox)
		clearButton.setOnAction(e->clearAction());
		saveButton.setOnAction(e->saveAction());
		cutButton.setOnAction(e->cutAction());
		copyButton.setOnAction(e->copyAction());
		pasteButton.setOnAction(e->pasteAction());
		wrapCheckBox.setOnAction(e->wrapAction());
	}

	public void saveFile(){

		try {
			PrintWriter output = new PrintWriter("stuff.txt");
			output.println(textArea.getText());
			output.close();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public void loadFile(){
		//scans the file
		try(Scanner inputFile = new Scanner(new File("stuff.txt"))){
			//goes through each line and prints it in the textArea
			while(inputFile.hasNext()){
				String inputLine = inputFile.nextLine();
				textArea.appendText(inputLine + "\n");
			}
		}
		catch(FileNotFoundException fnf){
			System.out.println("File not found...");
		}
		catch(NoSuchElementException Variable){
			System.out.println("No such element...");
		}
	}

	public static void main(String[] args) {
		launch(args);
	}
}
