
new TikzItem2
{
    Id = 1,
    Title = "Hai tam giác đối xứng qua gốc tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai tam giác ABC và A'B'C' đối xứng qua gốc tọa độ O trên lưới tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado1.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.5,>=stealth,font=\footnotesize]
\draw[line width=0.05pt,dashed,gray] (-5,-5) grid (5,5); 
\coordinate (O) at (0,0);

\draw[->] (-5,0)--(5,0) node[below]{$x$};
\draw[->] (0,-5)--(0,5) node[right]{$y$};
\draw (0,0) node[above left,font=\tiny]{$O$};
\tkzDefPoints{1/1/A,2/1/B,1/2/C}
\coordinate (A') at ($(O)!-2!(A)$);
\coordinate (B') at ($(O)!-2!(B)$);
\coordinate (C') at ($(O)!-2!(C)$);
\tkzDrawPolygon[thick](A,B,C)
\tkzDrawPolygon[thick](A',B',C')
\tkzDrawPoints[size=5,fill=black](A,B,C,A',B',C')
\tkzLabelPoints[below,font=\tiny](A,B,C')
\tkzLabelPoints[above,font=\tiny](C,A',B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Ba điểm thẳng hàng trên trục hoành",
    Category = "Đồ thị hình toạ độ",
    Description = "Ba điểm O, A, B thẳng hàng trên trục hoành với lưới tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado2.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\draw[line width=0.1pt,dashed] (-1.4,-0.4) grid (5.4,0.4); 
\tkzDefPoints{0/0/O,4/0/B,2/0/A}
\tkzDrawPoints[size=10,fill=black](O,A,B)
\tkzLabelPoints[below left,font=\footnotesize](O,A,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Phép tịnh tiến tam giác trên lưới",
    Category = "Đồ thị hình toạ độ",
    Description = "Phép tịnh tiến tam giác ABC thành A'B'C' theo vector từ (0,4) đến (5,0) trên lưới tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado3.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.4, line join=round, line cap=round]
\def\xt{-5.5} \def\xp{5.5} \def\yt{5.1} \def\yd{-4.1} % x_trái, x_phải, y_trên, y_dưới (giới hạn)
\draw[line width=0.1pt,dashed] (\xt,\yd) grid (\xp,\yt); % Lưới toạ độ
\draw[->] (\xt,0)--(\xp,0) node [below]{$x$};
\draw[->] (0,\yd)--(0,\yt) node [left]{$y$};
\node at (0,0) [below left]{$O$};
\tkzDefPoints{-1/3/A,-1/1/C,-4/2/B,0/4/a,5/0/b}
\tkzDefPointBy[translation=from a to b](A)\tkzGetPoint{A'}
\tkzDefPointBy[translation=from a to b](B)\tkzGetPoint{B'}
\tkzDefPointBy[translation=from a to b](C)\tkzGetPoint{C'}
\tkzDrawPoints[size=7,fill=black](A,B,C,A',B',C')
\tkzLabelPoints[below left](B,B')
\tkzLabelPoints[below](C,C')
\tkzLabelPoints[above](A,A')
\tkzDrawPolygon(A,B,C)
\tkzDrawPolygon(A',B',C')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Phép quay điểm M quanh gốc tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Phép quay điểm M(1,-1) thành M'(1,1) và điểm A(1,0) thành A'(0,1) quanh gốc O với các cung tròn minh họa.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado4.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\draw[->] (-1,0)--(2,0) node [below]{$x$};
\draw[->] (0,-1.5)--(0,1.5) node [left]{$y$};
\draw[left,fill=black] (0,-1) node{$-1$} circle (1pt);
\draw[left,fill=black] (0,1) node{$1$} circle (1pt);
\draw[below right,fill=black] (1,0) node{$1$} circle (1pt);
\tkzDefPoints{1/0/A,0/1/B,1/1/M',1/-1/M,0/1/A',0/0/O}
\tkzDrawPoints[size=5,fill=black](A',M,M',A,O)
\tkzDrawSegments(O,M' O,M)
\tkzMarkSegments[mark=||](O,M' O,M)
\tikzset{compass style/.append style={-stealth,dashed,very thick}}
\tkzDrawArc[towards,arrows=-stealth](O,M)(M')
\tkzDrawArc[towards,arrows=-stealth](O,A)(A')
\tkzLabelPoints[below](M)
\tkzLabelPoints[above right](A',M')
\tkzLabelPoints[below left](O,A)
\draw[dashed](A')--(M')--(M)--(0,-1);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Phép quay điểm M thành M' với cung tròn",
    Category = "Đồ thị hình toạ độ",
    Description = "Phép quay điểm M(1,1) thành M'(0,√2) quanh gốc O, hai đoạn OM và OM' có độ dài bằng nhau.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado5.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round,>=stealth]
\draw[->] (-1,0)--(2,0) node [below]{$x$};
\draw[->] (0,-0.5)--(0,2) node [left]{$y$};
\draw[left,fill=black] (0,1) node{$1$} circle (1pt);
\draw[below,fill=black] (1,0) node{$1$} circle (1pt);
\pgfmathsetmacro\x{sqrt(2)}
\tkzDefPoints{0/0/O,1/1/M,0/\x/M'}
\tkzDrawPoints[size=5,fill=black](O,M,M')
\tkzDrawSegments(O,M)
\tkzMarkSegments[mark=||](O,M O,M')
\tikzset{compass style/.append style={-stealth,dashed,very thick}}
\tkzDrawArc[towards,arrows=-stealth](O,M)(M')
\draw[dashed](1,0)--(1,1)--(0,1);
\tkzLabelPoints[right](M)
\tkzLabelPoints[left](M')
\tkzLabelPoints[below left](O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Ba điểm O, A, B trên trục hoành (lưới)",
    Category = "Đồ thị hình toạ độ",
    Description = "Ba điểm O(0,0), A(2,0), B(4,0) thẳng hàng trên trục hoành với lưới nền.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado6.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\draw[line width=0.1pt,dashed] (-1.4,-0.4) grid (5.4,0.4); 
\tkzDefPoints{0/0/O,4/0/B,2/0/A}
\tkzDrawPoints[size=10,fill=black](O,A,B)
\tkzLabelPoints[below left,font=\footnotesize](O,A,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Hai điểm và vector trên lưới",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai điểm A(-1,3) và B(5,1) với vector v trên lưới tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado7.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.5, line join=round, line cap=round]
\def\xt{-5.5} \def\xp{5.5} \def\yt{7.1} \def\yd{-1.1} % x_trái, x_phải, y_trên, y_dưới (giới hạn)
\draw[line width=0.1pt,dashed] (\xt,\yd) grid (\xp,\yt); % Lưới toạ độ
\draw[->] (\xt,0)--(\xp,0) node [below]{$x$};
\draw[->] (0,\yd)--(0,\yt) node [left]{$y$};
\node at (0,0) [below left]{$O$};
\tkzDefPoints{-1/3/A,5/1/B,-5/4/a,-2/5/b}
\tkzDrawPoints[size=7,fill=black](A,B)
\tkzLabelPoints[below left](A,B)
\draw[->] (b)--(a);
\draw (-3,5) node {$\overrightarrow{v}$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Hai tam giác song song trên lưới",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai tam giác ABC và A'B'C' với A(-4,3), C(-4,1), B(-2.5,1) và A'(4,-1), C'(4,-3), B'(5.5,-3) trên lưới tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado8.png",
    Code = @"\begin{tikzpicture}[scale=0.7,>=stealth, line join=round, line cap=round]
\draw[dashed,line width=0.1pt] (-5,-4) grid (6,4);
\draw[->,line width = 1pt] (-5,0)--(0,0)%
node[below right]{$O$}--(6.5,0) node[below]{$x$};
\draw[->,line width = 1pt] (0,-4.5) --(0,4.5) node[right]{$y$};
\foreach \x in {-5,-4,-3,-2,-1,1,2,3,4,5}{
\draw[-,line width=1.3pt] (\x,-.1)--(\x,.1) node[above,blue]{$\x$};}
\foreach \y in {-4,-3,-2,-1,1,2,3,4}{
\draw[-,line width=1.3pt] (-.1,\y)--(.1,\y) node[right,blue]{$\y$};}
\tkzDefPoints{-4/3/A,-4/1/C,-2.5/1/B,4/-1/A',4/-3/C',5.5/-3/B'}
\tkzDrawPolygon[line width =1.5pt](A,B,C)
\tkzDrawPolygon[line width =1.5pt](A',B',C')
\tkzLabelPoints[above](A,A')
\tkzLabelPoints[left](C,C')
\tkzLabelPoints[right](B,B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Hai tam giác trên lưới tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai tam giác ABC và DEF vẽ trên lưới tọa độ với các đỉnh được đánh dấu rõ ràng.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado9.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=1cm,y=1cm,scale=0.7]
\tkzDefPoints{3/1/A, 2/-1/B, 1/2/C, -1/0/D, -2/-2/E, -3/1/F, 0/-0.3/O}
\tkzInit[xmin=-3.5,ymin=-2.5,xmax=3.75,ymax=2.75]
%\tkzAxeXY
\tkzGrid
\tkzClip
\draw[->] (-3.5,0) -- (3.65,0) node[below] {$x$};
\foreach \x in {-3,-2,-1,1,2,3}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) node[below] {\footnotesize $\x$}; 
\draw[->] (0,-2.5) -- (0,2.65) node[right] {$y$};
\foreach \y in {-2,-1,1,2}
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) node[right] {\footnotesize $\y$};
\tkzDrawSegments[line width=0.8pt](A,B B,C C,A E,F F,D D,E)
\tkzLabelPoints[right](A)
\tkzLabelPoints[above](C,D,F)
\tkzLabelPoints[below](E,B)
\tkzLabelPoints[right](O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Tam giác vuông A'IA'' trên lưới",
    Category = "Đồ thị hình toạ độ",
    Description = "Tam giác vuông tại I với các điểm A(-3,-2), A'(-1,-3), I(2,-2), A''(1,1) trên lưới tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado10.png",
    Code = @"\begin{tikzpicture}
\draw[color=gray!80,, xstep=1.0cm,ystep=1.0cm,dashed] (-3.44,-3.66) grid (3.7,3.72);
\draw[->,color=black] (-3.44,0.) -- (3.7,0.) node[below] {$x$};
\foreach \x in {-3,-2,-1,1,2,3}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) node[below] {\footnotesize $\x$};
\draw[->,color=black] (0.,-3.66) -- (0.,3.72) node[left] {$y$};
\foreach \y in {-3,-2,-1,1,2,3} 
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) node[left] {\footnotesize $\y$};
\coordinate (A') at (-1,-3) ; 
\coordinate (I) at (2,-2) ; 
\coordinate (A'') at (1,1) ; 
\coordinate (A) at (-3,-2) ; 
%\draw[dashed] (A)--(A') ;
\draw[thick] (A')--(I)--(A'') ;
\tkzMarkRightAngle(A'',I,A');
\draw[fill=red] (A) circle (1.5pt) node[above left] {$A$} ;
\draw[fill=red] (A'') circle (1.5pt) node[above right] {$A''$} ;
\draw[fill=red] (A') circle (1.5pt) node[above left] {$A'$} ;
\draw[fill=red] (I) circle (1.5pt) node[below right] {$I$} ;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Đường tròn và tam giác trên tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I bán kính 5 với tam giác AMB nội tiếp, các điểm A(0,8), B(7,9), M và M₀ trên đường tròn.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado11.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.4,>=stealth,font=\footnotesize]
\draw[->] (-5,0)--(8,0) node[below]{$x$};
\draw[->] (0,-5)--(0,10) node[right]{$y$};
\draw (0,0) node[above left]{$O$};
\tkzDefPoints{1/1/I,0/8/A,7/9/B,2.5/3/C}
\draw (I) circle(5cm);
\coordinate (M) at ($(I)+(70:5cm)$);
\tkzInterLC[R](C,A)(I,5cm)\tkzGetPoints{D}{M_0}
\tkzDrawPoints[size=5,fill=black](I,A,B,C,M_0,M)
\tkzDrawSegments(A,B M,A M,B)
\tkzDrawSegment[dashed](A,M_0)
\tkzLabelPoints[left,font=\scriptsize](A,C)
\tkzLabelPoints[right,font=\scriptsize](B,M_0)
\tkzLabelPoints[below,font=\scriptsize](M)
\tkzLabelPoints[left,font=\scriptsize](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Tam giác vuông OAB với góc vuông tại O",
    Category = "Đồ thị hình toạ độ",
    Description = "Tam giác AOB vuông tại O với A(-1,5), B(5,1), minh họa góc vuông và góc tạo bởi OA và OB.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado12.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round,>=stealth]
\def \xmin{-2.3};
\def \xmax{6.1};
\def \ymin{-1.3};
\def \ymax{6.1};
\tkzDefPoints{-1/5/A, 0/0/O, 5/1/B};
\draw[->] (\xmin, 0.) -- (\xmax,0.) node[anchor=north] {$x$};
\draw[->] (0.,\ymin) -- (0.,\ymax) node[anchor=west] {$y$};
\clip(\xmin,\ymin) rectangle (\xmax,\ymax);
\draw[dashed] (-1,0) node[below left] {$-1$} -- (-1,5)node[above left]{$ A $}--(0,5)node[right] {$5$};
\draw[dashed] (5,0) node[below] {$5$} -- (5,1)node[above right]{$ B $}--(0,1)node[above right] {$1$};
\draw (-1,5)--(0,0)--(5,1);
\draw[fill=black] (-1,0) circle (1pt) (-1,5) circle (1pt) (0,5) circle (1pt) (0,1) circle (1pt) (5,1) circle (1pt) (5,0) circle (1pt);
\draw[fill=black] (0,0) circle (1.5pt) node[below left] {$O$};
\tkzMarkAngle[arc=l,size=0.5 cm,arrows=<-](B,O,A);
\tkzMarkRightAngles(B,O,A);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Hai điểm I và I' với đường phụ",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai điểm I(3,-1) và I'(1,3) kẻ đường phụ đến các trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado13.png",
    Code = @"\begin{tikzpicture}[scale=.7]
\tkzInit[xmin=-3,xmax=3,ymin=-3,ymax=3]
\tkzDefPoints{0/0/O,1/3/I',3/-1/I,1/0/A,3/0/B,0/-1/C,0/3/D}
\draw[->,thick] (-4,0) -- (4.5,0) node[below] {$x$};
\draw[->,thick] (0,-4) -- (0,4.5) node[left] {$y$};
\tkzDrawPoints(O,I,I')
\tkzLabelPoint[above right](O){$O$}
\tkzLabelPoint[right](I){$I$}
\tkzLabelPoint[ right](I'){$I'$}
\tkzLabelPoint[left](D){$3$}
\tkzLabelPoint[left](C){$-1$}
\tkzLabelPoint[below](A){$1$}
\tkzLabelPoint[above](B){$3$}
\tkzDrawSegments[dashed](A,I' D,I' B,I C,I)
\tkzDrawSegments(O,I O,I')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Hai điểm I(4,1) và I'(1,-4) với đường phụ",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai điểm I(4,1) và I'(1,-4) với các đường phụ kẻ đến trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado14.png",
    Code = @"\begin{tikzpicture}[scale=.7]
\tkzInit[xmin=-3,xmax=3,ymin=-3,ymax=3]
\tkzDefPoints{0/0/O,1/-4/I,4/1/I',1/0/A,4/0/B,0/-4/C,0/1/D}
\draw[->,thick] (-4,0) -- (4.5,0) node[below] {$x$};
\draw[->,thick] (0,-4.5) -- (0,4.5) node[left] {$y$};
\tkzDrawPoints(O,I,I')
\tkzLabelPoint[above right](O){$O$}
\tkzLabelPoint[below](I){$I'$}
\tkzLabelPoint[ above](I'){$I$}
\tkzLabelPoint[left](D){$1$}
\tkzLabelPoint[left](C){$-4$}
\tkzLabelPoint[below right](A){$1$}
\tkzLabelPoint[below](B){$4$}
\tkzDrawSegments[dashed](A,I D,I' B,I' C,I)
\tkzDrawSegments(O,I O,I')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Đường tròn tâm I và tam giác MAB",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(3,-1) bán kính 2 với tam giác MAB, các điểm A(7,1), B(2,3), M và M₀ trên đường tròn.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado15.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.7,>=stealth,font=\footnotesize]
\draw[->] (-1,0)--(8.5,0) node[below]{$x$};
\draw[->] (0,-3)--(0,4) node[right]{$y$};
\draw (0,0) node[above left]{$O$};
\tkzDefPoints{3/-1/I,7/1/A,2/3/B,4/-1/C}
\draw (I) circle(2cm);
\coordinate (M) at ($(I)+(50:2cm)$);
\tkzInterLC[R](C,B)(I,2cm)\tkzGetPoints{M_0}{D}
\tkzDrawPoints[size=5,fill=black](I,A,B,C,M_0,M)
\tkzDrawSegments(A,B M,A M,B)
\tkzDrawSegments[dashed](B,C M,C)
\tkzLabelPoints[right,font=\scriptsize](A)
\tkzLabelPoints[above,font=\scriptsize](B,M)
\tkzLabelPoints[below,font=\scriptsize](C,M_0)
\tkzLabelPoints[left,font=\scriptsize](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Đường tròn tâm I cắt đường thẳng d",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(1,2) bán kính 2 cắt đường thẳng d (x=5) tại hai điểm N và N₀, đoạn MN.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado16.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.6,>=stealth,font=\footnotesize]
\draw[->] (-1.8,0)--(6,0) node[below]{$x$};
\draw[->] (0,-1)--(0,4.5) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\tkzDefPoints{1/2/I, 5/3.5/N,5/2/N_0,3/2/M_0}
\coordinate (M) at ($(I)+(-30:2cm)$);
\draw (5,-1)--(5,4.5) node[right]{$d$};
\draw (1,2) circle(2);
\tkzDrawSegments(M,N)
\tkzDrawSegment[dashed](I,N_0)
\tkzDrawPoints[size=5,fill=black](I,M,N,N_0,M_0)
\tkzLabelPoints[below,font=\scriptsize](M)
\tkzLabelPoints[above,font=\scriptsize](I)
\tkzLabelPoints[right,font=\scriptsize](N,N_0)
\draw[dashed] (1,-0)node[below]{$1$}--(1,2)--(0,2)node[left]{$2$};
\node[right,font=\scriptsize] at (2.8,2.25) {$M_0$};
\node[below] at (5.3,0) {$5$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Hình thoi OACB trên tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Hình thoi OACB với O(0,0), A(1,2), C(2,0), B(1,-2), đường chéo AC nằm trên trục hoành.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado17.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8, x=1.2cm,>=stealth,font=\footnotesize]
\draw[->] (-1,0)--(3,0) node[below]{$x$};
\draw[->] (0,-2.5)--(0,3) node[right]{$y$};
\draw (0,0) node[above left]{$O$};
\draw[fill=black] (0,0) circle(1.5pt) (2,0) circle(1.5pt) (1,2) circle(1.5pt) (1,-2) circle(1.5pt);
\draw (0,0)--(1,2)node[above]{$A$}--(2,0)node[below right]{$C$}--(1,-2)node[below]{$B$}--(0,0);
\draw[dashed] (1,0)node[below]{$a$}--(1,2)--(0,2)node[left]{$b$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Đường tròn tâm I và đường thẳng Δ",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(-5,0) bán kính 5 với đường thẳng Δ, điểm M trên đường tròn và điểm N là hình chiếu vuông góc.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado18.png",
    Code = @"\begin{tikzpicture}[scale=.35,font=\footnotesize,line join=round, line cap=round,>=stealth]
\pgfmathsetmacro{\r}{5}
\tkzDefPoints{-3.125/10/a, 7.375/-4/b, -5/0/I, 0/0/O}
\draw (-5,0) circle (\r);
\draw (a)--(b);
\tkzDefPointBy[projection=onto a--b](I)
\tkzGetPoint{N}
\tkzInterLC(I,N)(I,O)
\tkzGetPoints{K}{M}
\tkzDrawSegments[](I,N)
\tkzDrawPoints[fill=black](I,N,M,O)
\pgfresetboundingbox
\tkzLabelPoints[below](I)
\tkzLabelPoints[right](N)
\tkzLabelPoints[above](M)
\draw ($(a)+(0.8,-1)$) node[right]{$\Delta$}; 
\draw[->] (0,-6.5) -- (0,8.57) node[right]{ $y$};
\draw[->] (-12.8,0) -- (6.8,0) node[above]{ $x$};
\draw (.1,.1) node[below left]{$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Đường tròn tâm I qua điểm M",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(2,4) đi qua điểm M(1,2), bán kính OM = √5.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado19.png",
    Code = @"\begin{tikzpicture}[scale=0.7,>=stealth] 
\tkzDefPoints{0/0/O, 1/2/M, 2/4/I} 
\draw[->] (-1,0) -- (5,0)node[below]{$x$}; \foreach \x in {1,2} 
\draw[shift={(\x,0)}] (0pt,2pt) -- (0pt,-2pt) node[below] {\scriptsize $\x$}; 
\draw[->] (0,-1) -- (0,6.5)node[right]{$y$}; \foreach \y in {1,2,3,4} 
\draw[shift={(0,\y)}] (-2pt,0pt) -- (2pt,0pt) node[left] {\scriptsize $\y$}; 
\tkzDrawCircle(I,M)
\tkzDrawPoints(O,I,M)
\tkzLabelPoints[](I,O,M)
\tkzDrawSegments[](O,I) 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Đường thẳng d qua hai điểm",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường thẳng d đi qua điểm A(0,3) và P(1,0).",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado20.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6]
\draw[->] (-1,0)--(2.5,0) node[below]{$x$};
\draw[->] (0,-1)--(0,4) node[right]{$y$};
\tkzDefPoints{0/03/A,1/0/P};
\tkzDrawPoints(A,P);
\tkzDrawLine(A,P);
\node at (-0.3,-0.3) {$O$};
\node at (0.8,0) [below]{$1$};
\node at (0,2.7) [left]{$3$};
\node at (0.5,1.7) [right]{$d$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Đường thẳng qua A', B và điểm M",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường thẳng đi qua A(0,-2), A'(2,0), B(5,-9), M(3,-3) với các đường nối liền.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado21.png",
    Code = @"\begin{tikzpicture}[scale=1,>=stealth]
\draw[->] (0,-10)--(0,1.5) node[right]{\scriptsize $y$};
\draw[->] (-.5,0) -- (4.7,0) node[above]{\scriptsize $x$};
\draw (0.1,0.1) node[below left]{\scriptsize $O$};
\draw (0,0) circle (1pt);
\foreach \i in {1,2,3,4}
{
\draw (\i,-.05) -- (\i,.05) node[below]{\scriptsize $\i$};
}
\foreach \i in {-1,-2,-3,-9}
{
\draw (-.05,\i) -- (.05,\i) node[left]{\scriptsize $\i$};
}
\fill (0,-2) node[shift={(-10:5pt)}]{\scriptsize $A$} circle(1pt);
\fill (2,0) node[shift={(120:5pt)}]{\scriptsize $A'$} circle(1pt);
\fill (5,-9) node[shift={(180:5pt)}]{\scriptsize$B$} circle(1pt);
\fill (3,-3) node[shift={(0:8pt)}]{\scriptsize$M$} circle(1pt);
\draw (-1,1)--(4,-4) ; 
\draw[dashed] (0,-2)--(2,0)--(5,-9);
%\draw[samples=100,domain=-1.75:1.75,thick] plot (\x,{(\x)^4-2*(\x)^2});
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Đường tròn tâm I(0,-1) bán kính 1",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn có tâm I(0,-1) và bán kính 1, tiếp xúc với trục hoành tại gốc tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado22.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth]
\clip(-2,-3) rectangle (2.5,1.5);
\draw[->] (-2,0) -- (2,0);
\draw[color=black] (1.6,.3) node[right] {$x$};
\draw[->,color=black] (0,-2.5) -- (0,1.3);
\draw[color=black] (.1,1.1) node[right] {\normalsize $y$};
\draw[color=black] (0pt,-8pt) node[right] {$0$};
\draw (0,-1) circle (1cm); 
\draw (0,-1) node[right]{$I$};
\node[below left] at (0,-2) {$-2$};
\foreach \x in {-1,1}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) node[above] { $\x$};
\foreach \y in {-1,1}
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) node[left] {\normalsize $\y$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Đường tròn tâm I(2,2) bán kính √2",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn có tâm I(2,2) và bán kính √2.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado23.png",
    Code = @"\begin{tikzpicture}[line width=0.6pt,>=stealth,scale=0.7]
\draw[->] (-1,0)--(4,0) node[below]{$x$};
\draw[->] (0,-1)--(0,4) node[left]{$y$};
\draw (2,2) circle (sqrt 2);
\draw[fill=black] (2,2) circle (2pt) node[above]{$I$};
\draw[dashed] (2,0)--(2,2)--(0,2);
\node at (2,0) [below]{$2$};
\node at (0,2) [left]{$2$};
\node at (-0.3,-0.3) {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 24,
    Title = "Đường tròn tâm I(2,2) bán kính √2 (bản 2)",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn có tâm I(2,2) và bán kính √2, tương tự item 23.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado24.png",
    Code = @"\begin{tikzpicture}[line width=0.6pt,>=stealth,scale=0.7]
\draw[->] (-1,0)--(4,0) node[below]{$x$};
\draw[->] (0,-1)--(0,4) node[left]{$y$};
\draw (2,2) circle (sqrt 2);
\draw[fill=black] (2,2) circle (2pt) node[above]{$I$};
\draw[dashed] (2,0)--(2,2)--(0,2);
\node at (2,0) [below]{$2$};
\node at (0,2) [left]{$2$};
\node at (-0.3,-0.3) {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 25,
    Title = "Khoảng cách từ O đến đường thẳng",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường thẳng và điểm H là hình chiếu vuông góc của O lên đường thẳng, minh họa khoảng cách từ điểm đến đường thẳng.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado25.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,font=\footnotesize,>=stealth,scale=1]
\draw[->] (-2,0)--(1,0) node[above] {$x$};
\draw[->] (0,-3.5)--(0,2.5) node[left] {$y$};
\fill (0,0) circle (1pt) node [above right] {$O$}; 
\draw (-2,2.5)--(1,-3.5);
\fill ($(-2,2.5)!(0,0)!(1,-3.5)$) coordinate [label=below left:$H$] (H) circle(1pt);
\path (1,-3.5) coordinate (x) (0,0) coordinate (O);
\draw (O)--(H);
\tkzMarkRightAngles[size=0.2](O,H,x)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Hình vành khăn với hai đường tròn đồng tâm",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai đường tròn đồng tâm I(-1,3) với bán kính 5 và 3, tạo thành hình vành khăn có hoa văn gạch chéo.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado26.png",
    Code = @"\begin{tikzpicture}[scale=0.5, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\filldraw[pattern=north east lines] (-1,3) circle(5);
\draw[fill=white] (-1,3) circle(3);
\draw[->] (-7,0)--(5,0) node[below]{$x$};
\draw[->] (0,-2.5)--(0,9) node[left]{$y$};
\draw[dashed](-1,0)node[above left]{$-1$}--(-1,3)node[above]{$I$}--(0,3)node[right]{$3$};
\draw (0,0) node[below left] {$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Bốn điểm M, N, P, Q tạo hình chữ nhật",
    Category = "Đồ thị hình toạ độ",
    Description = "Bốn điểm M(-2,-3), N(-4,-3), P(3,2), Q(2,3) với các đường phụ kẻ đến trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado27.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6, line join=round, line cap=round]
\def\xt{-5.0} \def\xp{4.0} \def\yt{5.0} \def\yd{-4.0} % x_trái, x_phải, y_trên, y_dưới (giới hạn)
\draw[->] (\xt,0)--(\xp,0) node [below]{$x$};
\draw[->] (0,\yd)--(0,\yt) node [left]{$y$};
\clip (\xt-0.1,\yd+0.1) rectangle (\xp-0.1,\yt-0.1);
\draw[fill=black] (0,0) node [below left] {$O$} circle (1pt);
\draw[fill=black] (-4,0) node[above]{$-4$} circle (1pt);
\draw[fill=black] (-2,0) node[above]{$-2$} circle (1pt);
\draw[fill=black] (-4,-3) node[below left]{$N$} circle (1pt);
\draw[fill=black] (-2,-3) node[below]{$M$} circle (1pt);
\draw[fill=black] (0,-3) node[right]{$-3$} circle (1pt);
\draw[fill=black] (2,0) node[below]{$2$} circle (1pt);
\draw[fill=black] (3,0) node[below]{$3$} circle (1pt);
\draw[fill=black] (0,2) node[left]{$2$} circle (1pt);
\draw[fill=black] (0,3) node[left]{$3$} circle (1pt);
\draw[fill=black] (2,3) node[right]{$Q$} circle (1pt);
\draw[fill=black] (3,2) node[right]{$P$} circle (1pt);
\draw[-][dashed] (-4,0)--(-4,-3)--(0,-3);
\draw[-][dashed] (-2,0)--(-2,-3);
\draw[-][dashed] (2,0)--(2,3)--(0,3);
\draw[-][dashed] (3,0)--(3,2)--(0,2);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Năm điểm O, M, E, N, P, Q trên tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Năm điểm O(0,0), M(1,1), E(2,2), N(-2,-1.3), P(2,-1.5), Q(-2,2) với các đoạn thẳng nối.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado28.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=.7]
\draw[->](-2.5,0)--(2.5,0)node[below]{$x$};
\draw[->](0,-2.5)--(0,2.5)node[right]{$y$};
\path
(0,0)coordinate (O)
(1,1)coordinate (M)
(2,2)coordinate (E)
(-2,-1.3)coordinate (N)
(-2,2)coordinate (Q)
(2,-1.5)coordinate (P)
;
\foreach \x/\g in
{O/-117,M/120,N/-90,P/0,Q/90,E/90}
\fill[black](\x) circle (1pt)
($(\x)+(\g:4mm)$) node{$\x$}
;
\draw (E)--(O)--(N) (P)--(O)--(Q);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Năm điểm với tọa độ M(a,b) và E(2a,2b)",
    Category = "Đồ thị hình toạ độ",
    Description = "Năm điểm O, M(1,1), E(2,2), N, P, Q với đường phụ thể hiện M(a,b) và E(2a,2b).",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado29.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=.7]
\draw[->](-2.5,0)--(2.5,0)node[below]{$x$};
\draw[->](0,-2.5)--(0,2.5)node[right]{$y$};
\path
(0,0)coordinate (O)
(1,1)coordinate (M)
(2,2)coordinate (E)
(-2,-1.3)coordinate (N)
(-2,2)coordinate (Q)
(2,-1.5)coordinate (P)
;
\foreach \x/\g in
{O/-117,M/120,N/-90,P/0,Q/90,E/90}
\fill[black](\x) circle (1pt)
($(\x)+(\g:4mm)$) node{$\x$}
;
\draw (E)--(O)--(N) (P)--(O)--(Q);
\draw[black,dashed](1,0)node[below]{$a$}|-(0,1)node[left]{$b$} (2,0)node[below]{$2a$}|-(0,2)node[left]{$2b$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "Hình bình hành OACB trên tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Hình bình hành OACB với O(0,0), A(3,1), C(-1,2), B được xác định bởi quy tắc hình bình hành.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado30.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,x=1.0cm,y=1.0cm,>=stealth,scale=1]
\tkzDefPoints{0/0/O,-1/2/C,3/1/A}
\coordinate (B) at ($(A)+(C)$);
\draw[->] (-2.5,0) --(3.5,0) node[above]{$x$};
\draw[->] (0,-1) --(0,3.5) node[right]{$y$};
\fill (O) node[shift={(-130:2ex)}]{$O$} circle(1pt);
\fill (A) node[shift={(0:4ex)}]{$A(3;1)$} circle(1pt);
\fill (C) node[shift={(0:-5ex)}]{$C(-1;2)$} circle(1pt);
\fill (B) node[shift={(40:2ex)}]{$B$} circle(1pt);
\tkzDrawPolygon[fill=gray!80,opacity=0.3](O,A,B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Hai điểm M(1,2) và N(3,1)",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai điểm M(1,2) và N(3,1) với các đường phụ kẻ đến trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado31.png",
    Code = @"\begin{tikzpicture}[>=stealth, scale= 1,samples=1000,smooth,color=black,line width=0.6pt,xscale=1,yscale=1]
\draw[->] (-0.5,0) -- (3.5,0) node[below] { $x$};
\draw[->] (0,-0.5) -- (0,2.5) node[below right] {$y$};
\draw (0,0) node[below right] {\footnotesize $O$};
\foreach \x in {3}
\draw[thin] (\x,1pt)--(\x,-1pt) node [below] {$\x$};
\foreach \y in {2}
\draw[thin] (1pt,\y)--(-1pt,\y) node [left] {$\y$};
\draw[dashed] (1,0)--(1,2)--(0,2);
\draw[dashed] (3,0)--(3,1)--(0,1);
\fill (3,1) circle (1.5pt);
\fill (1,2) circle (1.5pt);
\draw (3,1) node[above]{$N$};
\draw (1,2) node[above]{$M$};
\draw (0,1) node[left]{$1$} circle (0pt);
\draw (1,0) node[below]{$1$} circle (0pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Điểm M(3,-1) trên tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Điểm M(3,-1) với đường phụ kẻ đến các trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado32.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=1cm,y=1cm]
\tkzInit[ymin=-1.5,ymax=2,xmin=-0.5,xmax=4]
\tkzClip
\draw [->] (-0.5,0)--(3.5,0)node[below]{$x$};
\draw [->] (0,-2)--(0,0)node[below left]{$O$} circle(1pt)--(0,1.5)node[right]{$y$};
\draw [dashed] (0,-1)node[left]{$-1$} circle(1pt)--(3,-1)node[below]{$M$}--(3,0)node[above]{$3$} circle(1pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 33,
    Title = "Hình vành khăn tô gạch chéo",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai đường tròn đồng tâm tạo thành hình vành khăn có hoa văn gạch chéo, tâm nằm trên trục hoành.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado33.png",
    Code = @"\begin{tikzpicture}[scale=0.6,font=\footnotesize,line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/O,2/2/I, 2/1/A1, 2/0/A2}
\pgfmathsetmacro{\a}{sqrt((2-2)^2 + (1-2)^2)}
\pgfmathsetmacro{\b}{sqrt((2-2)^2 + (0-2)^2)}
\draw (I) circle[radius=\b cm, pattern=north east lines,pattern color=gray];
\draw (I) circle[radius=\a cm, fill=white];
\draw[->](-1,0)--(5,0) node[below]{$x$};
\draw[->](0,-1)--(0,5) node[left]{$y$};
\draw (0,4) node[left]{$8$};
\draw (3,0) node[below]{$6$};
\draw[dashed](2,0)--(2,4)--(0,4);
\draw[dashed](0,2)--(3,2)--(3,0);
\draw (O) circle (1pt);
\draw (2,2) circle (1pt);
\draw (O) node[below left]{$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 34,
    Title = "Hình chữ nhật MNPQ",
    Category = "Đồ thị hình toạ độ",
    Description = "Hình chữ nhật MNPQ với M(1,2), N(-1,2), P(-1,-2), Q(1,-2) đối xứng qua gốc tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado34.png",
    Code = @"\begin{tikzpicture}[xscale=0.7,yscale=0.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\def\a{1} \def\b{0} \def\c{-4} \def\d{2} % Hệ số
\def\xt{-1.8} \def\xp{1.8} \def\yt{2.8} \def\yd{-2.8} % x_trái, x_phải, y_trên, y_dưới (giới hạn)
\draw[->] (\xt,0)--(\xp,0) node [below]{$x$};
\draw[->] (0,\yd)--(0,\yt) node [left]{$y$};
\node at (0,0) [below left]{$O$};
\clip (\xt-0.1,\yd+0.1) rectangle (\xp-0.1,\yt-0.1);
%\draw[smooth,samples=300] plot(\x,{\a*(\x)^3+\b*(\x)^2+\c*(\x)+\d});
\foreach \x in {-1,1} \fill (\x,0) circle(1.5pt) node [below left] {$\x$};
\foreach \y in {-2,2} \fill (0,\y) circle(1.5pt) node [above left] {$\y$};
\draw [dashed] (-1,2)--(-1,-2)--(1,-2)--(1,2)--(-1,2);
\draw [fill=black](1,2) circle(1.5pt)node [right]{$M$};
\draw [fill=black] (-1,2) circle(1.5pt)node [left]{$N$};
\draw [fill=black](-1,-2) circle(1.5pt)node [left]{$P$};
\draw [fill=black](1,-2) circle(1.5pt)node [right]{$Q$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 35,
    Title = "Điểm M(3,-1) đơn giản",
    Category = "Đồ thị hình toạ độ",
    Description = "Điểm M(3,-1) với các đường phụ kẻ đến trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado35.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
\draw[->] (-1,0)--(4,0) node[below]{$x$};
\draw[->] (0,-1.5)--(0,1) node[right]{$y$};
\draw (0,0) node[above left]{$O$};
\draw[fill=black] (3,-1) circle(1.5pt);
\draw[dashed] (3,-0)node[above]{$3$}--(3,-1)node[below]{$M$}--(0,-1)node[left]{$-1$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 36,
    Title = "Bốn điểm A, B, C, D trên tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Bốn điểm A(-1,4), B(3,-2), C(2,2), D(4,1) với các đường phụ kẻ đến trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado36.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,x=0.5cm,y=0.5cm,>=stealth,font=\footnotesize]
\draw[->] (-2,0)--(5.5,0) node[below]{$x$};
\draw[->] (0,-3)--(0,4.8) node[right]{$y$};
\draw (0,0) node[below right]{$O$};
\draw[fill=black] (3,-2) circle(1pt) (4,1) circle(1pt) (-1,4) circle(1pt) (2,2) circle(1pt);
\draw[dashed] (3,0)node[above]{$3$}--(3,-2)node[below]{$B$}--(0,-2)node[left]{$-2$}
(-1,0)node[below]{$-1$}--(-1,4)node[left]{$A$}--(0,4)node[right]{$4$}
(2,0)node[below]{$2$}--(2,2)node[above]{$C$}--(0,2)node[left]{$2$}
(4,0)node[below]{$4$}--(4,1)node[above]{$D$}--(0,1)node[left]{$1$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 37,
    Title = "Hai vector OM và ON",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai vector OM và ON từ gốc tọa độ đến các điểm M và N.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado37.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round,x=0.5cm,y=0.5cm,>=stealth,font=\footnotesize]
\draw[->] (-4,0)--(4,0) node [below]{$x$};
\draw[->] (0,-1)--(0,8) node [left]{$y$};
\draw (0,0) node[below right]{$O$};
\tkzDefPoints{0/0/O,1.6875/02.25/M,-2.21484375/7.59375/N}
\tkzDrawPoints[size=5,fill=black](M,N)
\tkzLabelPoints[above right](M)
\tkzLabelPoints[above left](N)
\tkzDrawSegments(O,M O,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 38,
    Title = "Năm điểm A, M, N, P, Q đối xứng",
    Category = "Đồ thị hình toạ độ",
    Description = "Năm điểm A, M, N, P, Q với các vector từ gốc tọa độ, thể hiện tính đối xứng quay.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado38.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round,>=stealth,font=\footnotesize]
\draw[->] (-2,0)--(2,0) node [below]{$x$};
\draw[->] (0,-2)--(0,2) node [left]{$y$};
\draw (0,0) node[below right]{$O$};
\tkzDefPoints{0/0/O,0.866/0.5/A}
\tkzDefPointBy[rotation=center O angle 120](A)\tkzGetPoint{N}
\tkzDefPointBy[rotation=center O angle 185](A)\tkzGetPoint{P}
\tkzDefPointBy[rotation=center O angle 100](A)\tkzGetPoint{M'}
\tkzDefPointBy[rotation=center O angle 210](A)\tkzGetPoint{Q'}
\coordinate (M) at ($(M')!-1!(O)$);
\coordinate (Q) at ($(Q')!-1!(O)$);
\tkzDrawPoints[size=5,fill=black](A,N,P,M,Q)
\tkzDrawSegments(O,A O,M O,N O,P O,Q)
\tkzLabelPoints[right](A)
\tkzLabelPoints[left](M,N,P)
\tkzLabelPoints[below](Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 39,
    Title = "Bốn điểm M, N, P, Q đối xứng qua trục",
    Category = "Đồ thị hình toạ độ",
    Description = "Bốn điểm M(3,1), N(-3,1), P(-3,-1), Q(3,-1) tạo hình chữ nhật đối xứng qua các trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado39.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
\draw[->] (-4,0)--(4,0) node[below]{$x$};
\draw[->] (0,-2)--(0,2) node[right]{$y$};
\draw (0,0) node[above left]{$O$};
\draw[fill=black] (3,-1) circle(1.5pt) (3,1) circle(1.5pt) (-3,-1) circle(1.5pt) (-3,1) circle(1.5pt);
\draw[dashed] (3,0)node[below right]{$3$}--(3,1)node[above]{$M$}--(0,1)node[above right]{$1$}--(-3,1)node[above]{$N$}--(-3,0)node[below left]{$-3$}--(-3,-1)node[below]{$P$}--(0,-1)node[below right]{$-1$}--(3,-1)node[below]{$Q$}--(3,0);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 40,
    Title = "Hình chữ nhật NMPQ đường nét đứt",
    Category = "Đồ thị hình toạ độ",
    Description = "Hình chữ nhật NMPQ với N(-1,2), M(1,2), P(-1,-2), Q(1,-2) được vẽ bằng đường nét đứt.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado40.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=1cm,y=1cm,scale=0.8]
\tkzInit[xmin=-1.9,xmax=1.7,ymin=-2.9,ymax=2.7]
\tkzDrawX
\tkzDrawY
\tkzDefPoints{-1/2/N,1/2/M,-1/-2/P,1/-2/Q}
\tkzLabelPoints[left](N, P)
\tkzLabelPoints[right](M, Q)
\tkzDrawSegments[dashed](N,M M,Q Q,P P,N)
\draw (0,0) node[below left] {$O$};
\draw (1,0) node[below right] {$1$};
\draw (-1,0) node[below left] {$-1$};
\draw (0,2) node[above right] {$2$};
\draw (0,-2) node[below right] {$-2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 41,
    Title = "Điểm M(2,1) với điểm rỗng",
    Category = "Đồ thị hình toạ độ",
    Description = "Điểm M(2,1) được biểu diễn bằng điểm rỗng (không tô màu) với các đường phụ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado41.png",
    Code = @"\begin{tikzpicture}
\draw[->] (-0.5,0) -- (2.5,0) node[below] {$x$};
\draw[->] (0,-0.5) -- (0,2.5) node[right] {$y$};
\node at (0,0) [below left] {\footnotesize $O$};
\node at (2,0) [below] {$2$};
\node at (0,1) [left] {$1$};
\node at (2,1) [above right] {$M$};
\draw[dashed]
(0,1)-|(2,0);
\draw[fill=white](2,1)circle(1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 42,
    Title = "Bốn điểm M, N, P, Q trên lưới tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Bốn điểm M(2,1), N(-1,1), P(-1,-2), Q(2,-2) trên lưới tọa độ chi tiết.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado42.png",
    Code = @"\begin{tikzpicture}[scale=0.6,thick,>=stealth]
\draw[->] (-2,0) -- (4,0) node [below left] {\tiny$x$};
\draw[->] (0,-3) -- (0,3) node [below right] {\tiny$y$};
\draw[step=1cm,gray,very thin] (-2,-3) grid (4,3);
\foreach \x/\xtext in {-1/-1, 1/1, 2/2, 3/3}
\draw[shift={(\x,0)}] (0pt,2pt)-- (0pt,-2pt) node[below] {\tiny $\xtext$};
\foreach \y/\ytext in {-2/-2,-1/-1,1/1,2/2}
\draw[shift={(0,\y)}] (2pt,0pt)-- (-2pt,0pt) node[left] {\tiny $\ytext$};
\draw[fill=black] (2,1) circle (0.05) node [above right] {\tiny$M$} (-1,1) circle (0.05) node [above left] {\tiny$N$} (-1,-2) circle (0.05) node [above left] {\tiny$P$} (2,-2) circle (0.05) node [above right] {\tiny$Q$};
\draw (-0.3,0) node[below] {\tiny $O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 43,
    Title = "Đường tròn và tam giác AMB với điểm D",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I bán kính 3 với các điểm A(-5,0), B(-6,-3), D(-2,0), M và tam giác AMB.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado43.png",
    Code = @"\begin{tikzpicture}[scale=0.8,>=stealth, font=\footnotesize, line join=round, line cap=round]
%\draw[color=gray!50,dashed] (-7,-7) grid (7,7);
%\draw[->] (-6,0)--(6,0) node [below]{$x$};
%\draw[->] (0,-6)--(0,6) node [left]{$y$};
\clip (-7,-4) rectangle (6,4);
%%%%%%%%%%%%%%%
\tkzDefPoints{0/0/I,-3/0/C,-5/0/A,-3/-3/N,-2/0/D,-6/-3/B}
\tkzDrawPoints[fill=black,size=7](I,C,A,D,B);
\tkzLabelPoints[above](I,A,D,B)
\tkzLabelPoints[above left](C)
\tkzDrawCircle[blue][radius](I,C);
\tkzInterLC[R](I,N)(I,3cm)\tkzGetPoints{K}{M};
\tkzDrawPoints[fill=black,size=7](M)
\tkzLabelPoints[below](M);
\tkzDrawSegments(A,M M,I M,B A,I D,M);
\tkzDrawSegments[dashed](D,B);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 44,
    Title = "Đường tròn và tam giác với điểm M",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(0,-1) bán kính 2, tam giác AA'M với A(4,-1), B(3,-3), A'(1,-1), M(-1,-2.732).",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado44.png",
    Code = @"\begin{tikzpicture}[scale=0.75, font=\footnotesize, line join=round, line cap=round,>=stealth]
\draw[->] (-3,0) --(5,0) node[below]{$x$};
\draw[->] (0,-4) --(0,2) node[left]{$y$};
\draw (0,0) node[below left=-3pt]{$O$};
\draw[dashed] (4,-1)--(4,0) (0,-3)--(3,-3)--(3,0) (1,0)--(1,-1);
\draw (4,-1)--(-1,-2.732)--(0,-1)--(4,-1) (3,-3)--(1,-1)--(-1,-2.732);
\draw (0,-1) circle (2);
\draw [fill=black] (0,-1)node[left]{$I$} circle (1.5pt);
\draw [fill=black] (4,-1) node[below right=-3pt]{$A$} circle (1.5pt);
\draw [fill=black] (3,-3)node[below right=-3pt]{$B$} circle (1.5pt);
\draw [fill=black] (1,-1)node[above left=-3pt]{$A'$} circle (1.5pt);
\draw [fill=black] (-1,-2.732)node[left]{$M$} circle (1.5pt);
\draw [fill=black] (1,0)node[above]{$1$} circle (1.5pt);
\draw [fill=black] (3,0)node[above]{$3$} circle (1.5pt);
\draw [fill=black] (4,0)node[above]{$4$} circle (1.5pt);
\draw [fill=black] (0,-3)node[below left=-3pt]{$-3$} circle (1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 45,
    Title = "Đường tròn tâm I(2,2) và dây cung AB",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(2,2) bán kính 2 với dây cung AB, A(1,1), B(5,2).",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado45.png",
    Code = @"\begin{tikzpicture}[>=stealth, scale=0.8]
\draw [->,line width=1pt] (-1.5,0)--(0,0) node[above left]{$O$}--(6,0)node[above] {$x$};
\draw [->,line width=1pt] (0,-1.5)--(0,5.5) node [right] {$y$};
\foreach \x in {-1,1,2,3,4,5}{
\draw (\x,-.1)--(\x,.1) node[below=0.15]{$\x$};}
\foreach \y in {-1,1,2,3,4,5}{
\draw [-] (-.1,\y)--(.1,\y) node[left=0.15]{$\y$};}
\draw (2,2) circle (2cm);
\draw [fill] (2,2) node[above]{$I$} circle (1pt);
\draw [fill] (1,1) node[above]{$A$} circle (1pt);
\draw [fill] (5,2) node[right]{$B$} circle (1pt);
\draw [-,dashed] (2,0)--(2,2)--(0,2);
\draw [-,dashed] (5,0)--(5,2)--(2,2);
\draw [-,dashed] (1,0)--(1,1)--(0,1);
\draw [-] (1,1)--(5,2);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 46,
    Title = "Tam giác ABC với đường cao CI",
    Category = "Đồ thị hình toạ độ",
    Description = "Tam giác ABC với A(2,3), B(5,-2), C(-1,-2) và đường cao CI vuông góc với AB.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado46.png",
    Code = @"\begin{tikzpicture}[line join=round, line cap=round, >=stealth, scale=0.7]
\tkzDefPoints{2/3/A, 5/-2/B, -1/-2/C}
\draw[->](-2,0)--(6,0) node[below left] {$x$};;
\draw[->](0,-3)--(0,4) node[below right] {$y$};
%\draw[color=gray] (-2,-3) grid (6,4);
\clip (-2,-3) rectangle (6,4);
\draw[fill=black] (0,0)circle(1.5pt)node [below left]{$ O $};
\foreach \x in {-1,...,5}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt);
\foreach \y in {-2,...,3}
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt);
\coordinate (I) at ($(B)!(C)!(A)$); 
\draw (I)--(C);
\tkzDrawPoints[fill=black](A,B,C,I)
\tkzMarkRightAngle(C,I,A)
\tkzDrawPolygon(A,B,C)
\draw ($(A)+(0.3,0.3)$)node{$A$} ($(B)+(0.3,0.3)$)node{$B$} ($(C)-(0.3,0.3)$)node{$C$} ($(I)+(0.3,0.3)$)node{$I$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 47,
    Title = "Đường tròn và dây cung MN",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm O bán kính √2 với điểm M, dây cung MN và điểm N(4,√2).",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado47.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tikzset{label style/.style={font=\footnotesize}}
\def\xmax{5}
\def\xmin{-2}
\def\ymax{2.5}
\def\ymin{-2}
\pgfmathsetmacro{\bk}{sqrt(2)}
\begin{scope}
\clip (\xmin,\ymin) rectangle (\xmax,\ymax);
\path
(0,0) coordinate (O)
+(150:\bk) coordinate (M) node[left]{$M$}
(4,\bk) coordinate (N) node[above right]{$N$}
;
\draw[-stealth, name path=ox] (\xmin,0)--(\xmax,0) node[below left]{$x$};
\draw[-stealth] (0,\ymin)--(0,\ymax) node[below right]{$y$};
\draw (O) circle (\bk);
\draw[fill=black]
(M) circle(1pt)--(N) circle(1pt)
;
\draw[dashed] (4,0)|-(0,\bk);
\end{scope}
\path
(0,0) node[below left]{$O$}
(4,0) node[below]{$4$}
(0,\bk) node[above left]{$\sqrt{2}$}
;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 48,
    Title = "Đường tròn tâm I(1,1) với đường kính AD",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(1,1) với đường kính AD, tia OI kéo dài cắt đường tròn tại A và D.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado48.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,x=1.0cm,y=1.0cm,>=stealth,scale=0.7,every node/.style={scale=0.7}]
\tkzDefPoints{0/0/O,1/1/I,-1/2/B}
\draw[->] (-2,0)--(4.5,0) node[above] {$x$};
\draw[->] (0,-2)--(0,4.5) node[above] {$y$};
\fill (0,0) node[shift={(-60:2ex)}]{$O$} circle(1pt);
\draw[fill] (3,0) circle (1pt) node[below] {$3$};
\draw[fill] (0,3) circle (1pt) node[above left] {$3$};
\draw[fill] (1,1) circle (1pt) node[above] {$I$};
\tkzDrawCircle(I,B)
\tkzDrawLines[add=1 and 3](O,I)
\tkzInterLC(I,O)(I,B) \tkzGetPoints{D}{A}
\draw[dashed](1,0)|-(0,1);
\tkzLabelPoints[below](A)
\tkzLabelPoints[above](D)
\tkzDrawPoints[fill=black](A,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 49,
    Title = "Hai đường thẳng cắt nhau tại gốc",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai đường thẳng đi qua gốc tọa độ, một đường thẳng qua (5/4, 0) và (0, -5/2), đường kia gọi là Δ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado49.png",
    Code = @"\begin{tikzpicture}[>=stealth]
\draw[->] (-1.5,0)--(0,0)node[below left]{$O$}--(2,0)node[above]{$x$};
\draw[->] (0,-3)--(0,1)node[left]{$y$};
\draw[smooth,line width=1] plot[domain=-0.25:1.35](\x,{2*(\x)-2.5});
\draw[smooth,line width=1] plot[domain=-0.5:1.25](\x,{-1/2*(\x)});
\draw (0,-5/2) node[right]{$-\frac{5}{2}$} (5/4,0) node[above]{$\frac{5}{4}$} (0.7,-2) node[above]{$\Delta$};
\draw[fill=black] (0,-5/2) circle (0.04);
\draw[fill=black] (5/4,0) circle (0.04);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 50,
    Title = "Đường thẳng d và vector OI",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường thẳng d và vector OI từ gốc tọa độ đến điểm I(1,1) trên lưới tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado50.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round, >=stealth]
\clip (-2.5,-1.5) rectangle (3.5,3.5);
\draw[->] (-2.5,0)--(3.5,0)node[below left]{$x$};
\draw[->] (0,-1.5)--(0,3.5)node[below left]{$y$};
\draw (-2,4)--(3,-1)node[below]{$d$};
\foreach \x in {-3,-2,-1,0,1,2,3}{
\draw[fill] (\x,0) circle(1pt);
}
\foreach \y in {-2,-1,1,2,3}{
\draw[fill] (0,\y) circle(1pt);
}
\draw[fill] (1,1)node[above right]{$I$} circle(1pt);
\draw (0,0)--(1,1);
\path
node at (2,0)[below]{$2$}
node at (0,2)[left]{$2$}
node at (0,0)[below left]{$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 51,
    Title = "Đường tròn tâm I và tiếp tuyến từ A",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(3,-3) bán kính 2 với tiếp tuyến từ điểm A(0,1), các tiếp điểm P và Q trên lưới.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado51.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6]
\draw[->] (-1,0)--(6,0) node[above] {$x$};
\draw[->] (0,-6)--(0,2) node[left] {$y$};
\coordinate (A) at (0,1);
\coordinate (P) at (1.8,-1.4);
\coordinate (Q) at (4.2,-4.6);
\coordinate (I) at (3,-3);
\draw[help lines] (-0.5,-5.5) grid (5.5,1.5);
\draw (I) circle (2cm);
\filldraw (A) node[left] {$A$} circle (1pt);
\filldraw (I) node[below left] {$I$} circle (1pt);
\filldraw (P) node[left] {$P$} circle (1pt);
\filldraw (Q) node[below right] {$Q$} circle (1pt);
\draw (A)--(Q);
\draw[dashed] (3,0)node[above] {$3$}--(3,-3)--(0,-3) node[left] {$-3$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 52,
    Title = "Đường tròn tâm I(0,-1) bán kính 1 (bản 2)",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn có tâm I(0,-1) và bán kính 1, tiếp xúc với trục hoành, tương tự item 22.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado52.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth]
\clip(-2,-3) rectangle (2.5,1.5);
\draw[->] (-2,0) -- (2,0);
\draw[color=black] (1.6,.3) node[right] {$x$};
\draw[->,color=black] (0,-2.5) -- (0,1.3);
\draw[color=black] (.1,1.1) node[right] {\normalsize $y$};
\draw[color=black] (0pt,-8pt) node[right] {$0$};
\draw (0,-1) circle (1cm); 
\draw (0,-1) node[right]{$I$};
\node[below left] at (0,-2) {$-2$};
\foreach \x in {-1,1}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) node[above] { $\x$};
\foreach \y in {-1,1}
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) node[left] {\normalsize $\y$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 53,
    Title = "Đường tròn tâm I(-5,0) và đường thẳng Δ (bản 2)",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(-5,0) bán kính 5 với đường thẳng Δ, tương tự item 18.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado53.png",
    Code = @"\begin{tikzpicture}[scale=.35,font=\footnotesize,line join=round, line cap=round,>=stealth]
\pgfmathsetmacro{\r}{5}
\tkzDefPoints{-3.125/10/a, 7.375/-4/b, -5/0/I, 0/0/O}
\draw (-5,0) circle (\r);
\draw (a)--(b);
\tkzDefPointBy[projection=onto a--b](I)
\tkzGetPoint{N}
\tkzInterLC(I,N)(I,O)
\tkzGetPoints{K}{M}
\tkzDrawSegments[](I,N)
\tkzDrawPoints[fill=black](I,N,M,O)
\pgfresetboundingbox
\tkzLabelPoints[below](I)
\tkzLabelPoints[right](N)
\tkzLabelPoints[above](M)
\draw ($(a)+(0.8,-1)$) node[right]{$\Delta$}; 
\draw[->] (0,-6.5) -- (0,8.57) node[right]{ $y$};
\draw[->] (-12.8,0) -- (6.8,0) node[above]{ $x$};
\draw (.1,.1) node[below left]{$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 54,
    Title = "Đường thẳng d trên lưới tọa độ",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường thẳng d trên lưới tọa độ, tương tự item 50.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado54.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round, >=stealth]
\clip (-2.5,-1.5) rectangle (3.5,3.5);
\draw[->] (-2.5,0)--(3.5,0)node[below left]{$x$};
\draw[->] (0,-1.5)--(0,3.5)node[below left]{$y$};
\draw (-2,4)--(3,-1)node[below]{$d$};
\foreach \x in {-3,-2,-1,0,1,2,3}{
\draw[fill] (\x,0) circle(1pt);
}
\foreach \y in {-2,-1,1,2,3}{
\draw[fill] (0,\y) circle(1pt);
}
\path
node at (2,0)[below]{$2$}
node at (0,2)[left]{$2$}
node at (0,0)[below left]{$O$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 55,
    Title = "Elip với các tiêu điểm và đỉnh",
    Category = "Đồ thị hình toạ độ",
    Description = "Elip có tâm O với các đỉnh A₁(-5,0), A₂(5,0), B₁(0,3), B₂(0,-3) và tiêu điểm F₁(-4,0), F₂(4,0).",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado55.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6, line join=round, line cap=round]
\draw[->] (-6,0)--(7,0) node [below]{$x$};
\draw[->] (0,-4)--(0,4.5) node [right]{$y$};
\node at (0,0) [below right]{$O$};
\tkzDefPoints{0/0/O,-5/0/A_1,5/0/A_2,0/-3/B_2,0/3/B_1,-4/0/F_1,4/0/F_2}
\draw (O) ellipse (5cm and 3cm);
\tkzDrawPoints[size=5,fill=black](A_1,A_2,B_1,B_2,F_1,F_2)
\tkzLabelPoints[above left](A_1)
\tkzLabelPoints[below left](B_2)
\tkzLabelPoints[above left](B_1)
\tkzLabelPoints[above right](A_2)
\tkzLabelPoints[below](F_1,F_2)
\node at (F_1)[above]{$-4$};
\node at (F_2)[above]{$4$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 56,
    Title = "Đường thẳng d: -2x+y+2=0",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường thẳng d có phương trình -2x+y+2=0, đi qua hai điểm (1,0) và (0,2).",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado56.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.7]
\draw[->,line width = 1pt] (-1,0) --(3,0) node[above]{$x$};
\draw[->,line width = 1pt] (0,-0.5) --(0,3) node[right]{$y$};
\draw (1,0) node[below]{$1$} circle (1pt);
\draw (0,2) node[right]{$2$} circle (1pt);
\draw (0,0) node[below left]{$O$};
\draw (0.5,1) node[right] {$d$};
\draw [thick,samples=100, domain=-0.3:1.2] plot (\x, {-2*(\x)+2});
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 57,
    Title = "Bốn đường tròn đồng tâm và tam giác",
    Category = "Đồ thị hình toạ độ",
    Description = "Bốn đường tròn đồng tâm O với bán kính 1, 2, 3, 4.359 và tam giác OMN, M'P với các điểm đặc biệt.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado57.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.75,>=stealth,font=\footnotesize]
\draw[->] (-5,0)--(5.5,0) node[below]{$x$};
\draw[->] (0,-5.5)--(0,5.5) node[right]{$y$};
\foreach \x in {-1,-2,-3,-4,1,2,3,4}\draw (\x,0.1)--(\x,-0.1) node [below left] {\footnotesize $\x$};
\foreach \y in {-1,-2,-3,-4,-5,1,2,3,4}\draw (0.1,\y)--(-0.1,\y) node [above left] {\footnotesize $\y$};
\coordinate (O) at (0,0);
\coordinate (Q) at (0,5);
\coordinate (A) at (0,-4.359);
\draw (O) circle(1cm);
\draw (O) circle(2cm);
\draw (O) circle(3cm);
\draw[blue] (O) circle(4.359cm);
\coordinate (M) at ($(O)+(70:1cm)$);
\coordinate (N) at ($(O)+(10:2cm)$);
\coordinate (M') at ($(O)+(70:3cm)$);
\coordinate (P) at ($(M')+(N)-(O)$);
\draw (O)--(M')--(P)--(N)--(O)--(P) (M)--(N);
\draw[dashed] (Q)--(P);
\foreach \x/\g in {O/140,M/100,N/-20,M'/100,P/70,Q/180,A/-50} \draw[fill=black] (\x) circle (.05)+(\g:.3) node{$\x$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 58,
    Title = "Đường tròn tâm I(1,2) với tiếp tuyến từ A",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường tròn tâm I(1,2) bán kính 4 với tiếp tuyến từ điểm A(-3,-2), các tiếp điểm N₁, N₂, N.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado58.png",
    Code = @"\begin{tikzpicture}[scale=0.6, line join=round, line cap=round,>=stealth,font=\footnotesize]
\tikzset{label style/.style={font=\footnotesize}}
\draw[->] (-4,0)--(6,0) node [below]{$x$};
\draw[->] (0,-3)--(0,7.5) node [left]{$y$};
\draw (0,0) node[above right]{$O$};
\tkzDefPoints{1/2/I,-3/-2/A}
\draw (I) circle(4cm);
\coordinate (N) at ($(I)+(130:4cm)$);
\tkzInterLC[R](A,I)(I,4cm)\tkzGetPoints{N_1}{N_2}
\tkzDrawPoints[size=5,fill=black](N_1,N_2,N)
\tkzLabelPoints[above right](N_2)
\tkzLabelPoints[above](N)
\tkzLabelPoints[right](N_1)
\tkzDrawSegments(A,N_2)
\tkzDrawSegments[dashed](A,N)
\draw[fill=black] (1,2) circle(1.5pt) (-3,-2) circle(1.5pt);
\draw[dashed] (1,0)node[below]{$1$}--(1,2)node[below right]{$I$}--(0,2)node[left]{$2$}
(-3,0)node[above left]{$-3$}--(-3,-2)node[left]{$A$}--(0,-2)node[below right]{$-2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 59,
    Title = "Năm điểm A, M, N, P, Q phép quay",
    Category = "Đồ thị hình toạ độ",
    Description = "Năm điểm A, M, N, P, Q với các vector từ gốc O, thể hiện phép quay 90° và phép đối xứng.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado59.png",
    Code = @"\begin{tikzpicture}[scale=1.3, line join=round,>=stealth,font=\footnotesize]
\draw[->] (-1.5,0)--(1.5,0) node [below]{$x$};
\draw[->] (0,-1.5)--(0,1.5) node [right]{$y$};
\draw (0,0) node[below right]{$O$};
\draw[dashed] (0.6124,0)--(0.6124,0.3535)--(0,0.3535);
\tkzDefPoints{0/0/O,0.6124/0.3535/A, 1/0/B}
\tkzDefPointBy[rotation=center O angle 90](A)\tkzGetPoint{M}
\tkzDefPointBy[reflection=over O--B](M)\tkzGetPoint{N}
\coordinate (Q) at ($(M)!-1!(O)$);
\coordinate (P) at ($(N)!-1!(O)$);
\tkzDrawPoints[size=5,fill=black](A,N,P,M,Q)
\tkzDrawSegments(O,A O,M O,N O,P O,Q)
\tkzLabelPoints[right](A)
\tkzLabelPoints[left](M,N)
\tkzLabelPoints[below](P)
\tkzLabelPoints[above](Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 60,
    Title = "Hai vector OM và ON đối xứng qua Ox",
    Category = "Đồ thị hình toạ độ",
    Description = "Hai vector OM(a,b) và ON(a,-b) đối xứng qua trục hoành, M(2,1) và N(2,-1).",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado60.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=1,>=stealth]
\draw[->] (-0.8,0)--(3,0) node[below]{$x$};
\draw[->] (0,-1.5)--(0,1.5) node[right]{$y$};
\draw (0,0) node[above left]{$O$};
\draw[fill=blue] (0,0) circle(1pt) (2,-1) circle(1.5pt) (2,1) circle(1.5pt);
\draw[thick,color=blue] (0,0)--(2,-1)node[right]{$N$} (0,0)--(2,1)node[above right]{$M$};
\draw [dashed] (0,-1)node[left]{$-b$}--(2,-1)--(2,1)--(0,1)node[left]{$b$};
\node[above] at (2.2,0) {$a$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 61,
    Title = "Đoạn thẳng MN và đường thẳng Δ",
    Category = "Đồ thị hình toạ độ",
    Description = "Đoạn thẳng MN với M(-1.5, 0.875), N(-1,1) và đường thẳng Δ có phương trình y=-x/2+1/8.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado61.png",
    Code = @"\begin{tikzpicture}[line join=round, line cap=round,>=stealth,thick,scale=1]
\tikzset{label style/.style={font=\footnotesize}}
%%Nhập giới hạn đồ thị và hàm số cần vẽ
\def \xmin{-2}
\def \xmax{2.0}
\def \ymin{-0.5}
\def \ymax{1.5}
\def \hamso{-1/2*(\x)+1/8}
\tkzDefPoints{0/0/O,-1.5/0.875/M,-1/1/N}
%\def \tiemcanxien{\x+1}
%%Tự động
\draw[->] (\xmin,0)--(\xmax,0) node[above] {$x$};
\draw[->] (0,\ymin)--(0,\ymax) node[below left] {$y$};
\draw[dashed] (-1,0)--(-1,1)--(0,1);
\draw (0,0) node [below left] {$O$};
\tkzDrawPoints[size=3,fill=black](M,O,N)
\tkzDrawSegments(N,M)
\draw (1,-3/8) node [below] {$\Delta$};
\draw[fill=black] (M) node [below left] {$M$};
\draw[fill=black] (N) node [above] {$N$};
\draw[fill=black] (-1,0) node [below] {$-1$};
\draw[fill=black] (0,1) node [right] {$1$};
%%Tự động
\begin{scope}
\clip (\xmin+0.01,\ymin+0.01) rectangle (\xmax-0.01,\ymax-0.01);
\draw[samples=350,domain=\xmin+0.01:\xmax-0.01,smooth,variable=\x] plot (\x,{\hamso});
\end{scope}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 62,
    Title = "Khoảng cách từ O đến đường thẳng d",
    Category = "Đồ thị hình toạ độ",
    Description = "Đường thẳng d: 4x+2y+3=0 với điểm M(-1.5, 1.5), H là hình chiếu vuông góc của O lên d.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado62.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
\draw[->] (-3,0)--(3.5,0) node[below]{$x$};
\draw[->] (0,-2.5)--(0,2.5) node[right]{$y$};
\draw (0,0) node[above right]{$O$};
\draw[line width=0.7pt,domain=-1.8:0.5] plot(\x,{-2*(\x)-1.5})node[above right]{$d \colon 4x+2y+3=0$};
\draw[fill=black] (0,0) circle(1.5pt) (-1.5,1.5) circle(1.5pt) (-0.6,-0.3) circle(1.5pt);
\draw[dashed] (0,0)--(-1.5,1.5)node[left]{$M$};
\draw (0,0)--(-0.6,-0.3)node[left]{$H$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 63,
    Title = "Điểm M(-4,-2) với đường phụ",
    Category = "Đồ thị hình toạ độ",
    Description = "Điểm M(-4,-2) với các đường phụ nét đứt kẻ đến trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado63.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.4]
\draw[->] (-5,0) --(2,0) node[above]{$x$};
\draw[->] (0,-3) --(0,1) node[right]{$y$};
\draw (-4,0) node[above]{$-4$} circle (1pt);
\draw (0,-2) node[right]{$-2$} circle (1pt);
\draw (-4,-2) node[below left]{$M$} circle (1pt);
\draw (0,0) node[below left]{$O$};
\draw [dashed] (-4,0)--(-4,-2)--(0,-2);
\draw[fill] (-4,-2) circle(3pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 64,
    Title = "Vector OM với M(a,b)",
    Category = "Đồ thị hình toạ độ",
    Description = "Vector OM từ gốc O đến điểm M(3,2) biểu diễn tọa độ M(a,b).",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado64.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.6,>=stealth,font=\footnotesize]
\draw[->] (-1,0)--(3.7,0) node[below]{$x$};
\draw[->] (0,-0.7)--(0,3) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\draw[fill=black] (0,0) circle(1.5pt) (3,2) circle(1.5pt);
\draw[dashed] (3,0)node[below]{$a$}--(3,2)node[above right]{$M$}--(0,2)node[left]{$b$};
\draw[thick,color=blue] (0,0)--(3,2);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 65,
    Title = "Số phức z=a+bi và số phức liên hợp",
    Category = "Đồ thị hình toạ độ",
    Description = "Biểu diễn số phức z=a+bi tại M(3,2) và số phức liên hợp z̄=a-bi tại (3,-2) trên mặt phẳng phức.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado65.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.5]
\draw[->,line width = 1pt] (-1.5,0)--(-1,0) node[below]{$O$}--(7,0) node[below]{$x$};
\draw[->,line width = 1pt] (0,-2.8) --(0,3) node[right]{$y$};
\foreach \x in {}{
\draw (\x,0) node[below]{$\x$} circle (1pt);
\draw (0,\x) node[left]{$\x$} circle (1pt);
}
\tkzDefPoints{0/0/O,3/2/M}
\tkzDrawPoints(O,M)
\tkzDefPoints{0/0/A,3/2/B}
\draw[->] (A)--(B);
%\tkzDrawVectors(A,B)
\draw (0,2) node[left]{$b$} circle (1pt);
\draw (3,0) node[below right]{$a$} circle (1pt);
\draw (3,2) node[above right ]{$z=a+bi$} circle (1pt);
\draw [dashed] (3,0)--(3,2)--(0,2);
\draw (0,-2) node[left]{$-b$} circle (1pt);
\draw (3,-2) node[below right ]{$\overline z=a-bi$} circle (1pt);
\draw [dashed] (3,0)--(3,-2)--(0,-2);
\tkzDefPoints{3/-2/C}
\draw[->] (A)--(C);
%\tkzDrawVectors(A,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 66,
    Title = "Vector biểu diễn điểm M(a,b)",
    Category = "Đồ thị hình toạ độ",
    Description = "Vector OM từ gốc O đến điểm M(3,2) với các ký hiệu a và b trên trục tọa độ.",
    ImagePath = "Do_thi_hinh_toa_do/hinhtoado66.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.5]
\draw[->,line width = 1pt] (-1.5,0)--(0,0) node[below right]{$O$}--(5,0) node[below]{$x$};
\draw[->,line width = 1pt] (0,-1) --(0,3.5) node[right]{$y$};
\foreach \x in {}{
\draw (\x,0) node[below]{$\x$} circle (1pt);
\draw (0,\x) node[left]{$\x$} circle (1pt);
}
\tkzDefPoints{0/0/O,3/2/M}
\tkzDrawPoints(O,M)
%\tkzDefPoints{0/0/A,3/2/B}
\draw[->] (O)--(M);
\draw (0,2) node[left]{$b$} circle (1pt);
\draw (3,0) node[below]{$a$} circle (1pt);
\draw (3,2) node[above right]{$M$} circle (1pt);
\draw [dashed] (3,0)--(3,2)--(0,2);
\end{tikzpicture}"
},

