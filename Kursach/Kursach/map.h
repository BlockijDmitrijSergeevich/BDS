#include <SFML\Graphics.hpp>

const int HEIGHT_MAP = 27;//размер карты высота
const int WIDTH_MAP = 40;//размер карты ширина 


sf::String TileMap[HEIGHT_MAP] = {
    "0000000000000000000000000000000000000000",
	"0m              m m m m m m m m m m m m0",
	"0              m m m m m m m m m m m m 0",
	"0             e                        0",
	"0             0                        0",
	"0             0                       m0",
	"0             0       e               a0",
	"0             0                        0",
	"0             0m   m                m  0",
	"0             0b   e          m  m  e  0",
	"0             0               a  b     0",
	"0             0      m        0  0     0",
	"0             0      e        0  0     0",
	"0eeeb         0               0  0     0",
	"0      m      0        e      0  0     0",
	"0      e      0               0  0     0",
	"0m            0          e    0  0     0",
	"0          m  0               0  0     0",
	"0          e  0            e  0  0    m0",
	"0eeeeeb       0eeeeeeeeeeee0ee0  0eeeee0",
	"0            m0                        0",
	"0b           a0                        0",
	"00b           0                        0",
	"000b             m  m  m  m  m  m  m   0",
	"0000eee   eeeeeeeeeeeeeeeeeeeeeeeeeeeee0",
	"     0ddddd0                             ",
	"      00000                              ",
};
