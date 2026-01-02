
new TikzItem2
{
    Id = 1,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac1.png",
    Code = @"\begin{tikzpicture}[scale=1.5]
\foreach \x in {0,60,...,300} {
\draw (\x:1 cm) -- (\x + 60:1 cm);
\draw (\x:1 cm) -- (\x + 180:1 cm);
}
\draw(0:1 cm) node[shift={(0.2,0)}] {$A$}; \draw(60:1 cm) node[shift={(0.2,0.2)}] {$B$}; 
\draw(120:1 cm) node[shift={(-0.2,0.2)}] {$C$}; \draw(180:1 cm) node[shift={(-0.2,0)}] {$D$}; 
\draw(240:1 cm) node[shift={(-0.2,-0.2)}] {$E$}; \draw(300:1 cm) node[shift={(0.2,-0.2)}] {$F$}; 
\draw(0,0.08 ) node[above] {$O$}; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac2.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoint(0,0){O}
\tkzDefPoint(2,0){E}
\tkzDefPointBy[rotation = center O angle 60](E) \tkzGetPoint{F}
\tkzDefPointBy[rotation = center O angle 120](E) \tkzGetPoint{A}
\tkzDefPointBy[rotation = center O angle 180](E) \tkzGetPoint{B}
\tkzDefPointBy[rotation = center O angle 240](E) \tkzGetPoint{C}
\tkzDefPointBy[rotation = center O angle 300](E) \tkzGetPoint{D}
\tkzDrawPoints[size=5,fill=black](A,B,C,D,E,F,O)
\tkzDrawSegments(A,B B,C C,D D,E E,F F,A)
\draw (A) node[above] {$A$} (B) node[left] {$B$} (C) node[below] {$C$} (D) node[below] {$D$} (E) node[right] {$E$} (F) node[above] {$F$} (O) node[below left] {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac3.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.5, line join = round, line cap = round]
\tkzInit[xmin=-4,xmax=4,ymin=-3.5,ymax=3.5]
\tkzClip
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/O,-3/0/A}
\tkzDefPointBy[rotation = center O angle 60](A) \tkzGetPoint{B}
\tkzDefPointBy[rotation = center O angle 120](A) \tkzGetPoint{C}
\tkzDefPointBy[rotation = center O angle 180](A) \tkzGetPoint{D}
\tkzDefPointBy[rotation = center O angle 240](A) \tkzGetPoint{E}
\tkzDefPointBy[rotation = center O angle 300](A) \tkzGetPoint{F}
\tkzDrawPoints(O,A,B,C,E,F)
\tkzDrawPolygon(A,B,C,D,E,F)
\tkzLabelPoints[above](E,F,O)
\tkzLabelPoints[below](B,C)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac4.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=0.6]
\coordinate[label=below left:$O$](O) at (0,0);
\coordinate[label=right :$C$](C) at (2,0);
\tkzDefPointBy[rotation= center O angle 60](C)\tkzGetPoint{B}
\tkzDefPointBy[rotation= center O angle 60](B)\tkzGetPoint{A}
\tkzDefPointBy[rotation= center O angle 60](A)\tkzGetPoint{F}
\tkzDefPointBy[rotation= center O angle 60](F)\tkzGetPoint{E}
\tkzDefPointBy[rotation= center O angle 60](E)\tkzGetPoint{D}
\tkzDrawPoints[fill=black](A,B,C,D,E,F,O)
\tkzDrawSegments(A,B B,C C,D D,E E,F F,A F,C)
\tkzLabelPoints[below](D,E)
\tkzLabelPoints[left](F)
\tkzLabelPoints[above](A,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac5.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=1]
\coordinate[label=below left:$O$](O) at (0,0);
\coordinate[label=right :$C$](C) at (2,0);
\tkzDefPointBy[rotation= center O angle 60](C)\tkzGetPoint{B}
\tkzDefPointBy[rotation= center O angle 60](B)\tkzGetPoint{A}
\tkzDefPointBy[rotation= center O angle 60](A)\tkzGetPoint{F}
\tkzDefPointBy[rotation= center O angle 60](F)\tkzGetPoint{E}
\tkzDefPointBy[rotation= center O angle 60](E)\tkzGetPoint{D}
\tkzDrawPoints[fill=black](A,B,C,D,E,F,O)
\tkzDrawSegments(A,B B,C C,D D,E E,F F,A F,C)
\tkzLabelPoints[below](D,E)
\tkzLabelPoints[left](F)
\tkzLabelPoints[above](A,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac6.png",
    Code = @"\begin{tikzpicture}[scale=1.7,thick]
\foreach \x in {0,60,...,300} {
\draw (\x:1 cm) -- (\x + 60:1 cm);
\draw (\x:1 cm) -- (\x + 180:1 cm);
}
\draw (0:1 cm) node[shift={(0.2,0)}] {$A$}; \draw (60:1 cm) node[shift={(0.2,0.2)}] {$B$};
\draw (120:1 cm) node[shift={(-0.2,0.2)}] {$C$}; \draw (180:1 cm) node[shift={(-0.2,0)}] {$D$};
\draw (240:1 cm) node[shift={(-0.2,-0.2)}] {$E$}; \draw (300:1 cm) node[shift={(0.2,-0.2)}] {$F$};
\draw (0,0.08 ) node[above] {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac7.png",
    Code = @"\begin{tikzpicture}[scale=2,very thick]
\foreach \x in {0,60,...,300} {
\draw (\x:1 cm) -- (\x + 60:1 cm);
\draw (\x:1 cm) -- (\x + 180:1 cm);
}
\draw(0:1 cm) node[shift={(0.2,0)}] {$A$}; \draw(60:1 cm) node[shift={(0.2,0.2)}] {$B$};
\draw(120:1 cm) node[shift={(-0.2,0.2)}] {$C$}; \draw(180:1 cm) node[shift={(-0.2,0)}] {$D$};
\draw(240:1 cm) node[shift={(-0.2,-0.2)}] {$E$}; \draw(300:1 cm) node[shift={(0.2,-0.2)}] {$F$};
\draw(0,0.08 ) node[above] {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac8.png",
    Code = @"\begin{tikzpicture}[scale=1.7,thick]
\foreach \x in {0,60,...,300} {
\draw (\x:1 cm) -- (\x + 60:1 cm);
\draw (\x:1 cm) -- (\x + 180:1 cm);
}
\draw (0:1 cm) node[shift={(0.2,0)}] {$A$}; \draw (60:1 cm) node[shift={(0.2,0.2)}] {$B$};
\draw (120:1 cm) node[shift={(-0.2,0.2)}] {$C$}; \draw (180:1 cm) node[shift={(-0.2,0)}] {$D$};
\draw (240:1 cm) node[shift={(-0.2,-0.2)}] {$E$}; \draw (300:1 cm) node[shift={(0.2,-0.2)}] {$F$};
\draw (0,0.08 ) node[above] {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac9.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[xmin=-0.2, xmax=4.2, ymin=-0.5, ymax=5.5]
\tkzClip
\tkzDefPoints{2/1.8/O,2/0/D}
\tkzDefPointBy[rotation=center O angle 72](D)\tkzGetPoint{C}
\tkzDefPointBy[rotation=center O angle 72](C)\tkzGetPoint{B}
\tkzDefPointBy[rotation=center O angle 72](B)\tkzGetPoint{A}
\tkzDefPointBy[rotation=center O angle 72](A)\tkzGetPoint{E}
\tkzDefPointBy[reflection=over A--B](O)\tkzGetPoint{M}
\tkzDefPointBy[reflection=over C--E](O)\tkzGetPoint{N}
\tkzDrawPoints[fill=black](O,A,B,C,D,E,M,N)
\tkzDrawSegments(A,B B,C C,D D,E E,A O,A O,B O,C O,D O,E M,D A,M B,M C,N E,N)
\tkzLabelPoints[above](M)
\tkzLabelPoints[above left](A)
\tkzLabelPoints[above right](B)
\tkzLabelPoints[below](D)
\tkzLabelPoints[below left](E)
\tkzLabelPoints[below right](C,N,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac10.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoint(0,0){O}
\tkzDefPoint(2,0){E}
\tkzDefPointBy[rotation = center O angle 60](E) \tkzGetPoint{F}
\tkzDefPointBy[rotation = center O angle 120](E) \tkzGetPoint{A}
\tkzDefPointBy[rotation = center O angle 180](E) \tkzGetPoint{B}
\tkzDefPointBy[rotation = center O angle 240](E) \tkzGetPoint{C}
\tkzDefPointBy[rotation = center O angle 300](E) \tkzGetPoint{D}
\tkzDrawPoints[size=5,fill=black](A,B,C,D,E,F,O)
\tkzDrawSegments(A,B B,C C,D D,E E,F F,A)
\draw (A) node[above] {$A$} (B) node[left] {$B$} (C) node[below] {$C$} (D) node[below] {$D$} (E) node[right] {$E$} (F) node[above] {$F$} (O) node[below left] {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac11.png",
    Code = @"\begin{tikzpicture}[scale=2,very thick]
\foreach \x in {0,60,...,300} {
\draw (\x:1 cm) -- (\x + 60:1 cm);
\draw (\x:1 cm) -- (\x + 180:1 cm);
}
\draw(0:1 cm) node[shift={(0.2,0)}] {$A$}; \draw(60:1 cm) node[shift={(0.2,0.2)}] {$B$};
\draw(120:1 cm) node[shift={(-0.2,0.2)}] {$C$}; \draw(180:1 cm) node[shift={(-0.2,0)}] {$D$};
\draw(240:1 cm) node[shift={(-0.2,-0.2)}] {$E$}; \draw(300:1 cm) node[shift={(0.2,-0.2)}] {$F$};
\draw(0,0.08 ) node[above] {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac12.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/D,5/0/B,2.5/-1/A,2.5/1/C}
\tkzDrawPoints[size=5,fill=black](A,B,C,D)
\tkzDrawPolygon(A,B,C,D)
\tkzLabelPoints[below](A)
\tkzLabelPoints[above](C)
\tkzLabelPoints[right](B)
\tkzLabelPoints[left](D)
\tkzDrawSegments(A,C B,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac13.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/D,5/0/B,2.5/-1/A,2.5/1/C}
\tkzDrawPoints[size=5,fill=black](A,B,C,D)
\tkzDrawPolygon(A,B,C,D)
\tkzLabelPoints[below](A)
\tkzLabelPoints[above](C)
\tkzLabelPoints[right](B)
\tkzLabelPoints[left](D)
\tkzDrawSegments(A,C B,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac14.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6, line join = round, line cap = round]
\tkzInit[xmin=-0.5,xmax=5.5,ymin=-1,ymax=4]
\tkzClip
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B,5/0/C,2/3/A}
\coordinate (M) at ($(B)!0.5!(C)$);
\coordinate (N) at ($(A)!0.5!(C)$);
\coordinate (P) at ($(B)!0.5!(A)$);
\tkzDrawSegments(A,B B,C C,A M,N N,P P,M)
\tkzDrawPoints(A,B,C,M,N,P)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B,C,M)
\tkzLabelPoints[left](P)
\tkzLabelPoints[right](N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac15.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.5, line join = round, line cap = round]
\tkzInit[xmin=-4,xmax=4,ymin=-3.5,ymax=3.5]
\tkzClip
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/O,-3/0/A}
\tkzDefPointBy[rotation = center O angle 60](A) \tkzGetPoint{B}
\tkzDefPointBy[rotation = center O angle 120](A) \tkzGetPoint{C}
\tkzDefPointBy[rotation = center O angle 180](A) \tkzGetPoint{D}
\tkzDefPointBy[rotation = center O angle 240](A) \tkzGetPoint{E}
\tkzDefPointBy[rotation = center O angle 300](A) \tkzGetPoint{F}
\tkzDrawPoints(O,A,B,C,E,F)
\tkzDrawPolygon(A,B,C,D,E,F)
\tkzLabelPoints[above](E,F,O)
\tkzLabelPoints[below](B,C)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](D)
\draw[->] (O)--(A);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac16.png",
    Code = @"\begin{tikzpicture}[scale=0.6,line join=round, line cap=round,>=stealth]
\tkzDefPoints{1/5/A, 5/5/B, 1/1/D}
\coordinate (C) at ($(B)+(D)-(A)$);
\tkzInterLL(A,C)(B,D) \tkzGetPoint{O}
\tkzDefMidPoint(A,B) \tkzGetPoint{M}
\tkzDefMidPoint(B,C) \tkzGetPoint{N}
\tkzDefMidPoint(C,D) \tkzGetPoint{P}
\tkzDefMidPoint(A,D) \tkzGetPoint{Q}
\tkzFillPolygon[color=blue!20](A,O,B)
\tkzFillPolygon[color=black!20](A,O,D)
\tkzDrawPoints(A,B,C,D,O)
\tkzLabelPoints[left](A,D)
\tkzLabelPoints[right](C,B)
\tkzLabelPoints[below](O)
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac17.png",
    Code = @"\begin{tikzpicture}[scale=0.5, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/D,7/0/C,3/3/A}
\coordinate (B) at ($(A)+(C)-(D)$);
\tkzDefMidPoint(A,B)\tkzGetPoint{M}
\tkzDefMidPoint(C,D)\tkzGetPoint{N}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(M,N)
\tkzDrawPoints(D,C,A,B,M,N)
\tkzLabelPoints[above](A,B,M)
\tkzLabelPoints[right](C)
\tkzLabelPoints[left](D)
\tkzLabelPoints[below](N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac18.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6, line join = round, line cap = round]
\tkzInit[xmin=-1,xmax=4.5,ymin=-0.5,ymax=4.5]
\tkzClip
\def\a{3}
\tkzDefPoints{0/0/A,\a/0/B,0/\a/D}
\tkzDefPointWith[colinear = at D](A,B)
\tkzGetPoint{C}
\coordinate (I) at ($(A)!0.5!(C)$);
\tkzDrawPoints(A,B,C,D,I)
\tkzDrawSegments(A,C B,D)
\tkzLabelPoints[right](B)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above](C,D,I)
\tkzDrawPolygon(A,B,C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac19.png",
    Code = @"\begin{tikzpicture}
\def\a{3} \def\h{2} \def\b{4}
\tkzDefPoints{0/0/A,\a/0/B,\b/\h/C}
\tkzDefPointWith[colinear = at C](B,A)
\tkzGetPoint{D}
\tkzDrawPoints(A,B,C,D)
\tkzLabelPoints[right](B)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above](C,D)
\tkzDrawPolygon(A,B,C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac20.png",
    Code = @"\begin{tikzpicture}[scale=0.5, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/D,7/0/C,3/3/A}
\coordinate (B) at ($(A)+(C)-(D)$);
\tkzDrawPolygon(A,B,C,D)
\tkzDrawPoints(D,C,A,B)
\tkzLabelPoints[left](A,D)
\tkzLabelPoints[right](B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac21.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzInit[xmin=-2,xmax=6, ymin=-1,ymax=4.5]\tkzClip
\tkzDefPoints{0/0/A,4/0/B,1/2/M,0/3/O}
\tkzDrawCircle(O,M)
\tkzDefPointBy[translation=from A to B](M)\tkzGetPoint{N}
\tkzDefPointBy[translation=from A to B](O)\tkzGetPoint{I}
\tkzDrawCircle(I,N)
\tkzDrawSegments(A,B A,M M,N N,B)
\tkzDrawPoints[fill=black](A,B,M,O,N,I)
\tkzLabelPoints[left]()
\tkzLabelPoints[right](N)
\tkzLabelPoints[above]()
\tkzLabelPoints[above left](O,M)
\tkzLabelPoints[above right](I)
\tkzLabelPoints[below](A,B)
\tkzLabelPoints[below left]()
\tkzLabelPoints[below right]()
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac22.png",
    Code = @"\begin{tikzpicture}[scale=0.5, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/D,7/0/C,3/3/A}
\coordinate (B) at ($(A)+(C)-(D)$);
\tkzDrawPolygon(A,B,C,D)
\tkzDrawPoints(D,C,A,B)
\tkzLabelPoints[left](A,D)
\tkzLabelPoints[right](B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac23.png",
    Code = @"\begin{tikzpicture}[scale=0.6,line join=round, font=\footnotesize,line cap=round,>=stealth]
\tkzDefPoints{1/5/A, 5/5/B, 1/1/D}
\coordinate (C) at ($(B)+(D)-(A)$);
\tkzInterLL(A,C)(B,D) \tkzGetPoint{O}
\tkzDefMidPoint(A,B) \tkzGetPoint{M}
\tkzDefMidPoint(B,C) \tkzGetPoint{N}
\tkzDefMidPoint(C,D) \tkzGetPoint{P}
\tkzDefMidPoint(A,D) \tkzGetPoint{Q}
\tkzFillPolygon[color=yellow](A,M,O)
\tkzDrawPoints(A,B,C,D,O,M,N,P,Q)
\tkzLabelPoints[left](A,D,Q)
\tkzLabelPoints[above](M)
\tkzLabelPoints[right](C,B,N)
\tkzLabelPoints[below](P,O)
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D M,O N,Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 24,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac24.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A, 2/3/B, 7/3/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\tkzInterLL(A,C)(B,D)
\tkzGetPoint{O}
\tkzDefMidPoint(A,B)
\tkzGetPoint{M}
\tkzDefMidPoint(A,D)
\tkzGetPoint{N}
\tkzDrawSegments(A,B B,C C,D D,A B,D M,N M,O N,O A,C)
\tkzLabelPoints[above](O)
\tkzLabelPoints[above left](A,M,B)
\tkzLabelPoints[below](N)
\tkzLabelPoints[below right](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 25,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac25.png",
    Code = @"\begin{tikzpicture}[scale=1]
\coordinate (B) at (1,-1); \coordinate (C) at (4,-1); \coordinate (D) at (4,2);
\coordinate (A) at (1,2); \coordinate (O) at (2.5,0.5);\coordinate (E) at (5.5,0.5);
\coordinate (F) at (-0.5,3.5);
\draw (B)--(C)--(D)--(A)--cycle; \draw (B)--(D) (C)--(A); 
\draw (B) node[shift={(-0.25,-0.25)}] {$B$};
\draw(A) node[shift={(-0.25,0.25)}] {$A$};
\draw (C)node[shift={(0.25,-0.25)}] {$C$};
\draw (D) node[shift={(0.25,0.25)}] {$D$};
\draw (O) node[shift={(0,-0.35)}] {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac26.png",
    Code = @"\begin{tikzpicture}[thick,scale=1]
\coordinate (B) at (1,-1); \coordinate (C) at (4,-1); \coordinate (D) at (4,2);
\coordinate (A) at (1,2); \coordinate (O) at (2.5,0.5);\coordinate (E) at (5.5,0.5);
\coordinate (F) at (-0.5,3.5);
\draw (B)--(C)--(D)--(A)--cycle; \draw (B)--(D) (C)--(A) (E)--(B)--(F) (E)--(D) (E)--(C) (E)--(O); 
\draw (B) node[shift={(-0.25,-0.25)}] {$B$};
\draw(A) node[shift={(-0.25,0.25)}] {$A$};
\draw (C)node[shift={(0.25,-0.25)}] {$C$};
\draw (D) node[shift={(0.25,0.25)}] {$D$};
\draw (O) node[shift={(0,-0.35)}] {$O$};
\draw (E) node[below] {$E$};
\draw (F) node[left] {$F$};
\draw[dashed] (E) arc (18.43:108.43:4.74) ;
\tkzMarkRightAngle[size=0.3](F,B,E);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac27.png",
    Code = @"\begin{tikzpicture}[scale=0.5, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/D,7/0/C,3/3/A}
\coordinate (B) at ($(A)+(C)-(D)$);
\tkzDrawPolygon(A,B,C,D)
\tkzDrawPoints(D,C,A,B)
\tkzLabelPoints[left](A,D)
\tkzLabelPoints[right](B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac28.png",
    Code = @"\begin{tikzpicture}[scale=1]
\coordinate (M) at (0,0); \coordinate (N) at (2,0); \coordinate (P) at (2,2);
\coordinate (Q) at (0,2); \coordinate (O) at (1,1);
\draw (M)--(N)--(P)--(Q)--cycle; \draw (M)--(P) (N)--(Q); 
\draw (M) node[shift={(-0.25,-0.25)}] {$M$};
\draw(Q) node[shift={(-0.25,0.25)}] {$Q$};
\draw (N)node[shift={(0.25,-0.25)}] {$N$};
\draw (P) node[shift={(0.25,0.25)}] {$P$};
\draw (O) node[shift={(0,-0.35)}] {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac29.png",
    Code = @"\begin{tikzpicture}[scale=0.6, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,4/4/C,0/4/D}
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(C)!0.5!(B)$);
\tkzDrawPoints[size=5,fill=black](A,B,C,D,M,N)
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C B,D)
\tkzLabelPoints[below](A,M,B)
\tkzLabelPoints[above](C,D)
\tkzLabelPoints[right](N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac30.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round]
\tkzInit[xmin=-4,xmax=8,ymin=-1,ymax=8]
\tkzDefPoints{-4/0/A,0/0/B,2.5/0/E,-4/4/D,0/2.5/G}
\tkzDefPointBy[translation = from A to B](D)
\tkzGetPoint{C}
\tkzDefPointBy[translation = from B to E](G)
\tkzGetPoint{F}
\tkzDefMidPoint(A,G)\tkzGetPoint{M}
\tkzDefMidPoint(C,E)\tkzGetPoint{N}
\tkzDrawPoints(A,B,C,D,E,F,G,M,N)
\tkzLabelPoint[below](A){$A$}
\tkzLabelPoint[below](B){$B$}
\tkzLabelPoint[below](E){$E$}
\tkzLabelPoint[above](D){$D$}
\tkzLabelPoint[above](C){$C$}
\tkzLabelPoint[above](F){$F$}
\tkzLabelPoint[above](M){$M$}
\tkzLabelPoint[above left](G){$G$}
\tkzLabelPoint[right](N){$N$}
\tkzDrawSegments(A,B B,E E,F F,G B,C C,D D,A A,G C,E) 
\tkzDrawSegments[dashed](B,M B,N M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac31.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round]
\tkzInit[xmin=-4,xmax=8,ymin=-1,ymax=8]
\tkzDefPoints{-4/0/A,0/0/B,2.5/0/E,-4/4/D,0/2.5/G}
\tkzDefPointBy[translation = from A to B](D)
\tkzGetPoint{C}
\tkzDefPointBy[translation = from B to E](G)
\tkzGetPoint{F}
\tkzDefMidPoint(A,G)\tkzGetPoint{M}
\tkzDefMidPoint(C,E)\tkzGetPoint{N}
\tkzDrawPoints(A,B,C,D,E,F,G,M,N)
\tkzLabelPoint[below](A){$A$}
\tkzLabelPoint[below](B){$B$}
\tkzLabelPoint[below](E){$E$}
\tkzLabelPoint[above](D){$D$}
\tkzLabelPoint[above](C){$C$}
\tkzLabelPoint[above](F){$F$}
\tkzLabelPoint[above](M){$M$}
\tkzLabelPoint[above left](G){$G$}
\tkzLabelPoint[right](N){$N$}
\tkzDrawSegments(A,B B,E E,F F,G B,C C,D D,A A,G C,E) 
\tkzDrawSegments[dashed](B,M B,N M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac32.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,6/0/B,3/1.5/C,1/1.5/D, 1/0/H}
\tkzDrawSegments(A,B B,C C,D D,A D,H)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,H)
\tkzMarkRightAngle[size=0.2](D,H,B)
\tkzMarkRightAngle[size=0.2](H,D,C)
\tkzLabelPoints[below](A,B,H)
\tkzLabelPoints[above](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 33,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac33.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{-2.2/0/A,0/-1/B,2.2/0/C,0/1/D, 0/0/I}
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzDrawSegments[dashed](A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,I)
\tkzMarkRightAngle[size=0.2](D,I,C)
\tkzLabelPoints[below](B)
\tkzLabelPoints[above](D)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](C)
\tkzLabelPoints[below right](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 34,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac34.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 0/-4/C};
\tkzDefPointBy[rotation = center A angle -60](C)\tkzGetPoint{B};
\tkzDefPointBy[rotation = center A angle 60](C)\tkzGetPoint{D};
\tkzDrawPolygon(A,B,C,D);
\tkzDrawSegments(A,C);
\tkzDrawPoints[fill=black](A,B,C,D);
\tkzLabelPoints[above](A);
\tkzLabelPoints[left](B);
\tkzLabelPoints[below](C);
\tkzLabelPoints[right](D);
\tkzMarkAngles[size=0.7cm,arc=l](C,B,A);
\tkzLabelAngles[pos=1.2](C,B,A){$60^\circ$};
\tkzMarkSegments[mark=||](A,B B,C C,D D,A);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 35,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac35.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 4/0/B};
\tkzDefSquare(A,B)\tkzGetPoints{C}{D};
\coordinate (M) at ($(A)!0.5!(D)$);
\coordinate (N) at ($(D)!0.5!(C)$);
\coordinate (P) at ($(C)!0.5!(B)$);
\coordinate (Q) at ($(B)!0.5!(A)$);
\tkzInterLL(A,C)(B,D) \tkzGetPoint{O};
\tkzDrawPolygon(A,B,C,D);
\tkzDrawSegments(A,C B,D);
\tkzDrawPolygon[fill=gray](O,N,D);
\tkzDrawPoints[fill=black](A,B,C,D,M,N,P,Q,O);
\tkzLabelPoints[above](C,D,N);
\tkzLabelPoints[below](A,B,O,Q);
\tkzLabelPoints[right](P);
\tkzLabelPoints[left](M);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 36,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac36.png",
    Code = @"\begin{tikzpicture}
\path 
(-3,0) coordinate (D)
(3,0) coordinate (C)
($(D)+(65:3)$) coordinate (A)
($(C)+(115:3)$) coordinate (B)
($(C)!(A)!(D)$) coordinate (M)
($(C)!(B)!(D)$) coordinate (N)
;
\draw[thick] (A)--(B)--(C)--(D)-- cycle;
\draw[dashed] (A)--(M) (B)--(N);
\foreach \x/\g in {A/120,B/60,C/-60,D/-120,M/-90,N/-90} \fill[black] (\x) circle (1pt)
($(\g:3mm)+(\x)$) node {$\x$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 37,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac37.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/O,4/0/A,2/3.5/B};
\coordinate (C) at ($(A)+(B)$);
\coordinate (I) at ($(O)!.5!(C)$);
\tkzDrawSegments(O,A O,B A,C B,C O,C A,B);
\tkzLabelPoints[below](A,O,I);
\tkzLabelPoints[above](B,C);
\tkzDrawPoints[fill=black,size=4](A,B,C,O,I);
\tkzMarkRightAngle(O,I,B);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 38,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac38.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,3/0/B}
\tkzDefSquare(A,B)\tkzGetPoints{C}{D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{I}
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(B)!0.5!(C)$);
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawSegments[dashed](A,N D,M)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,I,M,N)
\tkzLabelPoints[below](A,B,M)
\tkzLabelPoints[above](C,D,I)
\tkzLabelPoints[right](N)
\tkzMarkRightAngle[size=0.25](C,I,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 39,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac39.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,4/2/C,0/2/D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{I}
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzDrawSegments[dashed](A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,I)
\tkzLabelPoints[below](A,B)
\tkzLabelPoints[above](C,D,I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 40,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac40.png",
    Code = @"\begin{tikzpicture}
\path 
(-3,0) coordinate (D)
(3,0) coordinate (C)
($(D)+(65:3)$) coordinate (A)
($(C)+(115:3)$) coordinate (B)
;
\fill[cyan!50] (-4.5,-1) rectangle (4,0);
\draw[thick] (A)--node[above]{$a \text{(m)}$}(B)--node[right]{$a \text{(m)}$}(C)--(D)--node[left]{$a \text{(m)}$} cycle;
\node at (0,-1.5) {\it Hình 36};
\foreach \x/\g in {A/120,B/60,C/-60,D/-120} \fill[black] (\x) circle (1pt)
($(\g:3mm)+(\x)$) node {$\x$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 41,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac41.png",
    Code = @"\begin{tikzpicture}[line join=round, line cap=round,scale=0.9]
\coordinate (A) at (0,3);
\coordinate (B) at (5,3);
\coordinate (D) at (0,0);
\coordinate (C) at ($(B)+(D)-(A)$);
\draw(A)--(B)--(C)--(D)--cycle;
\draw (0,0) rectangle (1,1) (A) rectangle (1,2) (B) rectangle (4,2) (4,1) rectangle (C);
\draw[dashed] (1,1) rectangle (4,2);
% \foreach \i/\g in {A/90,B/90,C/-90,D/-90}{\draw[fill=black](\i) circle (1pt) ($(\i)+(\g:3mm)$) node[scale=1]{$\i$};}
\draw (0,.5) node [left] {$x$};
\draw (.5,0) node [below] {$x$};
\draw (0,2.5) node [left] {$x$};
\draw (0.5,3) node [above] {$x$};
%%%%%%%%%
\draw (4.5,0) node [below] {$x$};
\draw (5,0.5) node [right] {$x$};
\draw (5,2.5) node [right] {$x$};
\draw (4.5,3) node [above] {$x$};
%%%%%%%%
\draw[<->] (-1,0)--(-1,3) node[above,midway,sloped] {$30$cm};
\draw[<->] (0,-1)--(5,-1) node[above,midway] {$80$cm};
\path (current bounding box.south) node[below, black]{a)}; %dưới
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 42,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac42.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tkzInit[xmin=-5,xmax=6,ymin=-3,ymax=6]
\tkzDefPoints{0/0/A, 8/0/D, 8/6/C, 0/6/B, 0/1/E, 0/5/F, 1/6/G, 7/6/H, 8/5/I, 8/1/J, 1/0/M, 7/0/N}
\tkzDrawPoints(A,B,C,D,M,N,E,F,G,H,I,J)
\tkzLabelSegments[above](B,G H,C){$x$}
\tkzLabelSegments[right](C,I J,D){$x$}
\tkzLabelSegment[left](A,B){$10$}
\tkzLabelSegment[below](A,D){$16$}
\tkzDrawSegments[thin](A,B A,D B,C C,D F,I E,J G,M H,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 43,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac43.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-3.5,-1.5) rectangle (3.5,4);
%%%%%%%%%%%%%%%
\tkzDefPoints{-3/0/D,3/0/C,3/3/B,-3/3/A,-2/-0.6/F}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{I}
\coordinate (N) at ($(A)!0.5!(B)$);
\coordinate (E) at ($(C)!0.5!(D)$);
\coordinate (M) at ($(A)!0.8!(B)$);
\tkzDrawSegments(A,C B,D N,E)
\tkzDrawPolygon(A,B,C,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,I,N,E,M)
\tkzLabelPoints[above left](A)
\tkzLabelPoints[above right](B)
\tkzLabelPoints[below left](D)
\tkzLabelPoints[below right](C)
\tkzLabelPoints[below](E)
\tkzLabelPoints[above](N,M)
\tkzLabelPoints[above right](I)
\tkzDrawLines[add=0.2 and 0.2](E,F)
\tkzLabelLine[pos=1.2,below left](E,F){$d$}
\tkzMarkRightAngle[size=0.2](I,N,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 44,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac44.png",
    Code = @"\begin{tikzpicture}[>=stealth,line cap=round,line join=round,scale=.7,font=\footnotesize]
\tkzDefPoints{0/0/A,4/0/B,0/3/D,4/3/C}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawPoints(A,B,C,D)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](B)
\tkzLabelPoints[above](C)
\tkzLabelPoints[above](D)
\draw[->,red] (B)--(D);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 45,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac45.png",
    Code = @"\begin{tikzpicture}[scale=0.8,font=\footnotesize,line join=round,
line cap=round,>=stealth]
\tkzInit[xmin=-0.5,ymin=-0.5,xmax=8.5,ymax=3.0]\tkzClip
%\pgfresetboundingbox
\tkzDefPoints{0/0/A,2/0/C}
\tkzDefPointBy[rotation = center A angle 90](C)\tkzGetPoint{B}
\tkzDefPointBy[homothety = center A ratio 4](C)\tkzGetPoint{D}
\tkzDefPointBy[translation = from A to B](D)\tkzGetPoint{E}
\tkzDrawSegments[->](A,B A,D A,E A,C)
\tkzDrawSegments(B,C)
\tkzDrawSegments[dashed](E,B E,D)
\tkzDrawPoints(A,B,C,D,E)
\tkzLabelPoints[below](A,D,C)
\tkzLabelPoints[above](B,E)
\tkzMarkRightAngles(C,A,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 46,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac46.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A,2/3/B,5/0/D}
\coordinate (C) at ($(B)+(D)-(A)$);
\coordinate (O) at ($(A)!0.5!(C)$);
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints(A,B,C,D,O)
\tkzLabelPoints[above left](B)
\tkzLabelPoints[above right](C)
\tkzLabelPoints[below left](A)
\tkzLabelPoints[below right](D)
\tkzLabelPoints[above](O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 47,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac47.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-3.5,-1) rectangle (3.5,4);
%%%%%%%%%%%%%%%
\tkzDefPoints{-3/0/D,3/0/C,2/3/B,-2/3/A}
\coordinate (I) at ($(A)!0.5!(B)$);
\coordinate (J) at ($(C)!0.5!(D)$);
\tkzDrawSegments(I,J)
\tkzDrawPolygon(A,B,C,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D)
\tkzLabelPoints[above left](A)
\tkzLabelPoints[above right](B)
\tkzLabelPoints[below left](D)
\tkzLabelPoints[below right](C)
\tkzMarkRightAngle[size=0.2](C,J,I)
\tkzLabelPoints[below](J)
\tkzLabelPoints[above](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 48,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac48.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A,4/0/B,0/3/D,4/3/C}
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzDrawPoints(A,B,C,D)
\tkzLabelPoints[above left](D)
\tkzLabelPoints[above right](C)
\tkzLabelPoints[below left](A)
\tkzLabelPoints[below right](B)
\draw[->](A)--(B);
\draw[->](A)--(D);
\draw[->](A)--(C);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 49,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac49.png",
    Code = @"\begin{tikzpicture}[scale=1.0,font=\footnotesize,line join=round,
line cap=round,>=stealth]
%\tkzInit[xmin=-0.5,ymin=-0.5,xmax=7.0,ymax=5.5]\tkzClip
\pgfresetboundingbox
\tkzDefPoints{0/0/A,4/0/D}
\tkzDefPointBy[rotation = center A angle 90](D)\tkzGetPoint{B}
\tkzDefPointBy[rotation = center B angle 90](A)\tkzGetPoint{C}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawPolygon[color=black,line width =1pt](A,B,C,D)
\tkzDrawSegments(A,C B,D)
\tkzDrawPoints(A,B,C,D,O)
\tkzLabelPoints[right](O)
\tkzLabelPoints[below](A,D)
\tkzLabelPoints[above](C,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 50,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac50.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoints{0/0/A,1/2/B,4/0/D,5/2/C}
\tkzDrawPolygon(A,B,C,D)
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawPoints[fill=black](A,B,C,D,O)
\tkzLabelPoints[above](B,C,O)
\tkzLabelPoints[below](A,D)
\tkzDrawSegments(B,D)
\tkzDrawSegments(A,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 51,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac51.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tkzDefPoints{0/0/A, 4/0/B, -1/-2/D}
\tkzDefPointBy[translation=from A to B](D) \tkzGetPoint{C}
\tkzDefMidPoint(D,C) \tkzGetPoint{M}
\tkzInterLL(A,C)(B,D) \tkzGetPoint{O}
\tkzInterLL(A,C)(B,M) \tkzGetPoint{G}
\tkzDrawSegments(A,B B,C C,D A,D A,C B,D B,M)
\tkzLabelPoints[above](A,B)
\tkzLabelPoints[below](D,C,O,G)
\tkzDrawPoints[fill=black](A,B,C,D,O,G)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 52,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac52.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{-2/1.5/A,3/1.5/B,0/0/O}
\coordinate (C) at ($(O)!-1!(A)$);
\coordinate (D) at ($(A)+(C)-(B)$);
\tkzDrawPoints[size=5,fill=black](A,B,O,C,D)
\tkzLabelPoints[above](A,B,O)
\tkzLabelPoints[below](C,D)
\tkzDrawPolygon(A,B,C,D,A)
\draw (A)--(C) (B)--(D);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 53,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac53.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5/2/C}
\tkzDefPointBy[translation=from B to C](A)\tkzGetPoint{D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below,font=\footnotesize](A, B, O)
\tkzLabelPoints[above,font=\footnotesize](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 54,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac54.png",
    Code = @"\begin{tikzpicture}[scale=.5, line join=round, line cap=round]
%%%%%%%%%%%%%%%
\tkzDefPoints{0/0/A,4/0/B,0.5/2/D}
\tkzDefPointBy[translation = from A to B](D) \tkzGetPoint{C}
\tkzDrawPolygon(A,B,C,D)
\tkzLabelPoints[above](C,D)
\tkzLabelPoints[below](A,B)
\tkzDrawPoints(A,B,C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 55,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac55.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5/2/C}
\tkzDefPointBy[translation=from B to C](A)\tkzGetPoint{D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below,font=\footnotesize](A, B, O)
\tkzLabelPoints[above,font=\footnotesize](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 56,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac56.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5/2/C}
\tkzDefPointBy[translation=from B to C](A)\tkzGetPoint{D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below,font=\footnotesize](A, B, O)
\tkzLabelPoints[above,font=\footnotesize](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 57,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac57.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5/2/C}
\tkzDefPointBy[translation=from B to C](A)\tkzGetPoint{D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below,font=\footnotesize](A, B, O)
\tkzLabelPoints[above,font=\footnotesize](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 58,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac58.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5/2/C}
\tkzDefPointBy[translation=from B to C](A)\tkzGetPoint{D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below,font=\footnotesize](A, B, O)
\tkzLabelPoints[above,font=\footnotesize](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 59,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac59.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,3/0/B,3/3/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (M) at ($(C)!0.5!(D)$);
\tkzDrawSegments(A,B B,C C,D D,A A,M)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,M)
\tkzLabelPoints[below](A,B)
\tkzLabelPoints[above](C,D,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 60,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac60.png",
    Code = @"\begin{tikzpicture}[scale=.6]
\tkzDefPoints{0/0/B, 5/0/C}
\tkzDefPointBy[rotation = center B angle 60](C)\tkzGetPoint{A}
\tkzDefMidPoint(B,C)\tkzGetPoint{I}
\tkzDefPointBy[translation = from A to B](C)\tkzGetPoint{D}
\tkzDrawPoints(A,B,C,D,I)
\tkzDrawSegments(A,B B,C C,A B,D C,D A,D)
\tkzMarkSegments[mark=|](I,B I,C)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](C)
\tkzLabelPoints[below](D)
\node (I) at (2.3,-0.3) {$I$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 61,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac61.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tkzDefPoints{0/0/A, -1.6/-2/D, 4/-2/C}
\coordinate (B) at ($(A)+(C)-(D)$); 
\coordinate (M) at ($(A)!1/3!(B)$); 
\tkzDefMidPoint(D,C)\tkzGetPoint{N}
\tkzDefMidPoint(M,N)\tkzGetPoint{z1}
\tkzDefMidPoint(B,N)\tkzGetPoint{z2} 
\coordinate (G) at ($(M)!2/3!(z2)$); 
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(M,N N,B)
\tkzDrawSegments[dashed](M,z2 z1,B)
\tkzLabelPoints[above](A,B,M,G)
\tkzLabelPoints[below](D,C,N)
\tkzDrawPoints(G,z1,z2)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 62,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac62.png",
    Code = @"\begin{tikzpicture}[scale=0.5, line join=round, line cap=round]
\tkzDefPoints{0/0/A,2/3/B,8/3/C,6/0/D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below](A,D,O)
\tkzLabelPoints[above](B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 63,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac63.png",
    Code = @"\begin{tikzpicture}[scale=1,font=
\footnotesize,line join=round,line cap=round, >=stealth]
\tkzDefPoints{0/0/A,4/0/B,5/1.5/C}
\tkzDefPointBy[translation = from B to A](C) \tkzGetPoint{D}
\tkzInterLL(A,C)(B,D) \tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints(A,B,C,D,O)
\tkzLabelPoints[left](A,D)
\tkzLabelPoints[right](C,B)
\tkzLabelPoints[above](O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 64,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac64.png",
    Code = @"\begin{tikzpicture}[scale=0.5, line join=round, line cap=round]
\tkzDefPoints{0/0/A,2/3/B,8/3/C,6/0/D}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below](A,D)
\tkzLabelPoints[above](B,C,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 65,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac65.png",
    Code = @"\begin{tikzpicture}[scale=0.5, line join=round, line cap=round]
\tkzDefPoints{0/0/A,2/3/B,8/3/C,6/0/D}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below](A,D)
\tkzLabelPoints[above](B,C,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 66,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac66.png",
    Code = @"\begin{tikzpicture}[scale=0.5, line join=round, line cap=round]
\tkzDefPoints{0/0/A,2/3/B,8/3/C,6/0/D}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\coordinate (H) at ($(B)!0.5!(C)$);
\coordinate (K) at ($(A)!0.5!(D)$);
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O,H,K)
\tkzLabelPoints[below](A,D,K)
\tkzLabelPoints[above](B,C,O,H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 67,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac67.png",
    Code = @"\begin{tikzpicture}[scale=0.5, line join=round, line cap=round]
\tkzDefPoints{0/0/A,2/3/B,8/3/C,6/0/D}
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzDrawPoints[size=5,fill=black](A,B,C,D)
\tkzLabelPoints[below](A,D)
\tkzLabelPoints[above](B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 68,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac68.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoints{3/0/B,0/0/A,0/3/D}
\coordinate (C) at ($(D)+(B)$);
\coordinate (E) at ($(C)+(B)$);
\coordinate (F) at ($2*(B)$);
\tkzDefMidPoint(A,C)
\tkzLabelPoints[above left](D)
\tkzLabelPoints[above left](C,E)
\tkzLabelPoints[below left](B,A)
\tkzLabelPoints[below right](F)
\tkzDrawPoints(A,B,C,D,E,F)
\tkzDrawSegments(A,F A,D D,E E,F A,C A,E B,C B,E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 69,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac69.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,>=stealth,font=\footnotesize,scale=.7]
\tkzDefPoints{0/0/A}
\coordinate (B) at ($(A)+(6.2,0)$);
\tkzDefShiftPoint[A](70:3){D}
\coordinate (C) at ($(D)+(3,0)$);
\coordinate[label = left:$M$] (M) at ($(A)!1/2!(D)$);
\coordinate[label =right:$N$] (N) at ($(B)!1/2!(C)$);
\pgfresetboundingbox
\tkzDrawPolygon(A,B,C,D)
\draw (M)--(N);
\tkzDrawPoints[fill=black](A,B,C,D,M,N)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](B)
\tkzLabelPoints[left](D)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 70,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac70.png",
    Code = @"\begin{tikzpicture}[scale=.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\coordinate (A) at (0,0);
\coordinate (B) at (1,3);
\coordinate (C) at (4,3);
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (O) at ($(A)!1/2!(C)$);
\tkzDrawSegments(A,B B,C C,D A,D A,C B,D)
\tkzDrawPoints[fill=black](O,D,A,B,C)
\tkzLabelPoints[above](B,C)
\tkzLabelPoints[below](A,D,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 71,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac71.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A, -1/-2/D, 4/-2/C}
\coordinate (B) at ($(A)+(C)-(D)$);
\coordinate (O) at ($(A)!.5!(C)$);
\coordinate (M) at ($(A)!.5!(B)$);
\coordinate (N) at ($(D)!.5!(C)$);
\coordinate (P) at ($(O)!.33!(C)$);
\draw (2.2,-1) node[above left]{$O$} ;
\tkzDrawSegments[dashed](M,N B,N)
\tkzDrawPolygon(A,D,B)
\tkzDrawSegments(A,C D,C C,B)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above](M,B)
\tkzLabelPoints[below](N,D,C,P)
\tkzDrawPoints(A,B,C,D,M,N,P,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 72,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac72.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=1, line join = round, line cap = round]
\draw[smooth] (1,1)--(-2,-2)--(-5,-1)--(-5,3)--cycle;
\draw[smooth] (-5,3)--(-2,-2);
\draw[smooth] (1,1)--(-5,-1);
\draw[fill=black] (-5,3) circle (1pt) node[above] {$D$};
\draw[fill=black] (1,1) circle (1pt) node[above] {$C$};
\draw[fill=black] (-2,-2)circle (1pt) node[below] {$B$};
\draw[fill=black] (-5,-1) circle (1pt) node[below] {$A$};
\draw[fill=black] (-3.5,0.5) circle (1pt) node[above] {$J$};
\draw[fill=black] (-2,0) circle (1pt) node[above] {$I$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 73,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac73.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=1, line join = round, line cap = round]
\draw[smooth] (-4,0)--(1,0)--(3,2)--(-2,2)--cycle;
\draw[smooth] (-4,0)--(3,2);
\draw[smooth] (1,0)--(-2,2);
\draw[fill=black] (-4,0) circle (1pt) node[below] {$A$};
\draw[fill=black] (1,0) circle (1pt) node[below] {$B$};
\draw[fill=black] (-0.5,1) circle (1pt) node[below] {$O$};
\draw[fill=black] (0.67,1.33) circle (1pt) node[below] {$P$};
\draw[fill=black] (0.5,2) circle (1pt) node[above] {$N$};
\draw[fill=black] (-2,2) circle (1pt) node[above] {$D$};
\draw[fill=black] (3,2) circle (1pt) node[above] {$C$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 74,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac74.png",
    Code = @"\begin{tikzpicture}[scale=.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\coordinate (A) at (0,0);
\coordinate (B) at (0,3);
\coordinate (C) at (4,3);
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (H) at ($(B)!(A)!(D)$);
\coordinate (M) at ($(D)!1/2!(H)$);
\coordinate (N) at ($(C)!1/2!(B)$);
\coordinate (O) at ($(C)!1/2!(A)$);
\coordinate (K) at ($(A)!(B)!(M)$);
\tkzInterLL(B,K)(A,H) \tkzGetPoint{E}
\tkzDrawSegments(A,B B,C C,D A,D B,D A,H A,M B,K M,N M,E)
\tkzDrawPoints[fill=black](M,N,D,A,B,C,O,H,K,E)
\tkzLabelPoints[above](B,C,N)
\tkzLabelPoints[below](A,D,O,K,M)
\tkzLabelPoints[left](E,H)
\tkzMarkRightAngles[size=0.2](A,B,C A,H,D B,K,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 75,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac75.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,fill=black, >=stealth]
\coordinate (A) at (0,0);
\coordinate (B) at (-2,-2);
\coordinate (D) at (4,0);
\coordinate (C) at (2,-2);
\coordinate (O) at (1,-1);
\tkzLabelPoints[below](B,C,O)
\tkzLabelPoints[above](A,D)
\tkzDrawSegments(A,B B,C C,D D,A B,D A,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 76,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac76.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5/2/C}
\tkzDefPointBy[translation=from B to C](A)\tkzGetPoint{D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below,font=\footnotesize](A, B, O)
\tkzLabelPoints[above,font=\footnotesize](C,D)
\node[below] at (2,0) {Hình 1.};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 77,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac77.png",
    Code = @"\begin{tikzpicture}[scale=0.6, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1/2/B,5/2/C,4/0/D}
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzDrawPoints[size=5,fill=black](A,B,C,D)
\tkzLabelPoints[below](A,D)
\tkzLabelPoints[above](B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 78,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac78.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1/2/B,5/2/C,4/0/D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below, font=\footnotesize](A,D)
\tkzLabelPoints[above, font=\footnotesize](B,C,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 79,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac79.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1/2/B,5/2/C,4/0/D}
\coordinate (M) at ($(C)!0.5!(B)$);
\coordinate (N) at ($(A)!0.5!(D)$);
\tkzDrawSegments(A,B B,C C,D D,A M,N)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,M,N)
\tkzLabelPoints[below, font=\footnotesize](A,D,N)
\tkzLabelPoints[above, font=\footnotesize](B,C,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 80,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac80.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5/2/C}
\tkzDefPointBy[translation=from B to C](A)\tkzGetPoint{D}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzDrawSegments(A,B B,C C,D D,A A,C B,D)
\tkzDrawPoints[size=5,fill=black](A,B,C,D,O)
\tkzLabelPoints[below,font=\footnotesize](A, B, O)
\tkzLabelPoints[above,font=\footnotesize](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 81,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac81.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoints{0/0/D, 1/3/A, 4/3/B, 5/0/C}
\tkzDefLine[parallel=through B](A,D)\tkzGetPoint{I} 
\tkzInterLL(A,I)(B,D)\tkzGetPoint{O}
\tkzMarkRightAngle(I,O,B)
\tkzMarkSegments[mark=|](A,D A,B B,I D,I)
\tkzMarkAngles(C,D,B D,A,I B,D,A)
\tkzMarkAngles[mark=||](B,D,A C,D,B)
\tkzDrawSegments(A,B B,C C,D D,A B,I A,I B,D)
\tkzLabelPoints[above left](A)
\tkzLabelPoints[above right](B)
\tkzLabelPoints[below left](D)
\tkzLabelPoints[below right](C)
\tkzLabelPoints[below](I,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 82,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac82.png",
    Code = @"\begin{tikzpicture}[scale=1, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B,2/2/O}
\tkzDefPointBy[rotation=center O angle -90](B)
\tkzGetPoint{A}
\tkzDefPointBy[rotation=center O angle 180](B)
\tkzGetPoint{D}
\tkzDefPointBy[rotation=center O angle 90](B)
\tkzGetPoint{C}
\tkzDefPointBy[homothety=center A ratio 0.3](D)
\tkzGetPoint{E}
\tkzDefPointBy[rotation=center O angle -90](E)
\tkzGetPoint{F}
\tkzDefPointBy[rotation=center O angle 180](E)
\tkzGetPoint{G}
\tkzDefPointBy[rotation=center O angle 90](E)
\tkzGetPoint{H}
\tkzDrawPolygon[color=magenta](A,B,C,D)
\tkzDrawPolygon[color=magenta](E,F,G,H)
\tkzDefPointBy[homothety=center B ratio 1.05](A)
\tkzGetPoint{M}
\tkzDefPointBy[homothety=center B ratio 1.05](C)
\tkzGetPoint{P}
\tkzDefPointBy[translation=from A to E](M)
\tkzGetPoint{N}
\tkzDefPointBy[translation=from C to D](P)
\tkzGetPoint{Q}
\tkzLabelPoints[left](A,B,H)
\tkzLabelPoints[right](C,D,F)
\tkzLabelPoints[above](E)
\tkzLabelPoints[below](G)
\tkzFillPolygon[pattern=dots,pattern color=magenta](A,B,C,D)
\tkzFillPolygon[pattern=dots,pattern color=green](E,F,G,H)
\tkzDrawPoints(A,B,C,D,E,F,G,H)
\tkzLabelSegment[above](A,E){$x$}
\tkzLabelSegment[above](E,D){$20-x$}
%\tkzMarkAngle[mark=|](C,A,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 83,
    Title = "Bảng biến thiên f(x)",
    Category = "Hình tứ giác",
    Description = "Bảng biến thiên của hàm số.",
    ImagePath = "Hinh_tu_giac/hinhtugiac83.png",
    Code = @"\begin{tikzpicture}[scale=1, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B,2/2/O}
\tkzDefPointBy[rotation=center O angle -90](B)
\tkzGetPoint{A}
\tkzDefPointBy[rotation=center O angle 180](B)
\tkzGetPoint{D}
\tkzDefPointBy[rotation=center O angle 90](B)
\tkzGetPoint{C}
\tkzDefPointBy[homothety=center A ratio 0.3](D)
\tkzGetPoint{E}
\tkzDefPointBy[rotation=center O angle -90](E)
\tkzGetPoint{F}
\tkzDefPointBy[rotation=center O angle 180](E)
\tkzGetPoint{G}
\tkzDefPointBy[rotation=center O angle 90](E)
\tkzGetPoint{H}
\tkzDrawPolygon[color=black](A,B,C,D)
\tkzDrawPolygon[color=magenta](E,F,G,H)
\tkzDefPointBy[homothety=center B ratio 1.05](A)
\tkzGetPoint{M}
\tkzDefPointBy[homothety=center B ratio 1.05](C)
\tkzGetPoint{P}
\tkzDefPointBy[translation=from A to E](M)
\tkzGetPoint{N}
\tkzDefPointBy[translation=from C to D](P)
\tkzGetPoint{Q}
%\tkzLabelPoints[below](A,B,C,D,E,F,G,H)
%\tkzFillPolygon[pattern=dots,pattern color=magenta](A,B,C,D)
\tkzFillPolygon[pattern=dots,pattern color=green](E,F,G,H)
\tkzDrawSegments[<->,above](M,N P,Q)
\tkzLabelSegment[above](M,N){$x\;\mathrm{cm}$}
\tkzLabelSegment[right](P,Q){$20\;\mathrm{cm}$}
%\tkzMarkAngle[mark=|](C,A,B)
\end{tikzpicture}"
},

