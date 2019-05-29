#include <SFML/Graphics.hpp>

using namespace sf;

View view;

void getplayercoordinateforview(float x, float y) { //функция для считывания координат игрока
	float tempX = x; float tempY = y;//считываем коорд игрока и проверяем их, чтобы убрать края

	if (x < 640) tempX = 640;//убираем из вида левую сторону
	if (x > 640) tempX = 640;
	if (y < 360) tempY = 360;
	if (y > 440) tempY = 440;	

	view.setCenter(tempX, tempY); //следим за игроком, передавая его координаты. 

}

void changeview() {

	if (Keyboard::isKeyPressed(Keyboard::U)) {
		view.zoom(1.0020f); //масштабируем, уменьшение
		//view.zoom(1.0006f); //тоже самое помедленнее соответственно
	}

	if (Keyboard::isKeyPressed(Keyboard::R)) {
		//view.setRotation(90);//сразу же задает поворот камере
		view.rotate(-1);//постепенно поворачивает камеру (отрицательное значение - в обратную сторону)
	}

	if (Keyboard::isKeyPressed(Keyboard::L)) {
		//view.setRotation(90);//сразу же задает поворот камере
		view.rotate(1);//постепенно поворачивает камеру (отрицательное значение - в обратную сторону)
	}

	if (Keyboard::isKeyPressed(Keyboard::I)) {
		view.setSize(1280, 720);//устанавливает размер камеры (наш исходный)
	}

	if (Keyboard::isKeyPressed(Keyboard::P)) {
		view.setSize(540, 380);//например другой размер
	}

	if (Keyboard::isKeyPressed(Keyboard::Q)) {
		view.setViewport(sf::FloatRect(0, 0, 0.5f, 1));//таким образом делается раздельный экран для игры на двоих. нужно только создать ещё один объект View и привязывать к нему координаты игрока 2.
	}
}