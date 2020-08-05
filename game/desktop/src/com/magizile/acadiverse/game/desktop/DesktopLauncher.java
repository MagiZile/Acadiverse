package com.magizile.acadiverse.game.desktop;

import com.badlogic.gdx.Files;
import com.badlogic.gdx.backends.lwjgl.LwjglApplication;
import com.badlogic.gdx.backends.lwjgl.LwjglApplicationConfiguration;
import com.badlogic.gdx.graphics.PixmapIO;
import com.magizile.acadiverse.game.MainClass;

public class DesktopLauncher {
	public static void main(String[] arg) {
		LwjglApplicationConfiguration config = new LwjglApplicationConfiguration();
		config.title = "Acadiverse";
		config.fullscreen = true;
		config.addIcon("Graphics/icon.png", Files.FileType.Internal);
		config.width = 1024;
		config.height = 768;
		config.pauseWhenMinimized = true;
		new LwjglApplication(new MainClass(), config);
	}
}

