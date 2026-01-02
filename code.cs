
new TikzItem2
{
    Id = 1,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_1.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.3, line join = round, line cap = round]
\tkzInit[xmin=-1.5,xmax=5.5,ymin=-1.5,ymax=7]
\tkzClip
\foreach \x in {0,2,4}{
\foreach \y in{0,2,4,6}{
\draw [fill=gray!60] (\x,\y) circle (1 cm);}}
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,2/0/B,4/0/C,0/2/D,0/2/M}
\tkzDefPointBy[translation = from A to M](B) \tkzGetPoint{B1}
\tkzDefPointBy[translation = from A to M](C) \tkzGetPoint{C1}
\tkzDefPointBy[translation = from A to M](M) \tkzGetPoint{A2}
\tkzDefPointBy[translation = from A to M](B1) \tkzGetPoint{B2}
\tkzDefPointBy[translation = from A to M](C1) \tkzGetPoint{C2}
\tkzDefPointBy[translation = from A to M](A2) \tkzGetPoint{A3}
\tkzDefPointBy[translation = from A to M](B2) \tkzGetPoint{B3}
\tkzDefPointBy[translation = from A to M](C2) \tkzGetPoint{C3}
\tkzLabelPoint(A){$10$}
\tkzLabelPoint(B){$11$}
\tkzLabelPoint(C){$12$}
\tkzLabelPoint(A3){$1$} \tkzLabelPoint(B3){$2$} \tkzLabelPoint(C3){$3$} \tkzLabelPoint(A2){$4$} \tkzLabelPoint(B2){$5$} \tkzLabelPoint(C2){$6$}
\tkzLabelPoint(M){$7$} \tkzLabelPoint(B1){$8$} \tkzLabelPoint(C1){$9$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_2.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=1, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B,5/0/C, 5/4/A, 6/3/O}
\tkzDrawPolygon(A,B,C)
\coordinate (I) at ($ (C)!0.5!(B) $);
\tkzCentroid(A,B,C) \tkzGetPoint{G}
\tkzDrawCircle[radius](O,A)
\tkzDefPointBy[homothety = center I ratio 1/3](O) \tkzGetPoint{O'}
\tkzLabelPoints[left](A,B,O,G)
\tkzLabelPoints[right](C)
\tkzDrawPoints(A,B,C,O,O',G,I)
\tkzLabelPoints[below](O',I)
\tkzDrawCircle[radius](O',G)
\draw (O)--(I)--(A);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_3.png",
    Code = @"\begin{tikzpicture}
\draw (0,0) node[left]{$D$} rectangle (4,2) node[right]{$B$};
\draw (0,2) node[left]{$A$} (4,0) node[right]{$C$}
(2,2) coordinate (E) node[above]{$E$}
(4,1) coordinate (F) node[right]{$F$}
(2,0) coordinate (H) node[below]{$H$}
(0,1) coordinate (K) node[left]{$K$}
(2,1) coordinate (O) node[above left]{$O$}
(3,0) coordinate (I) node[below]{$I$}
(1,1) coordinate (J) node[above]{$J$}
(3,1) coordinate (I1) node[above]{$I_1$};
\draw (K) -- (J) -- (E) (F) -- (O) -- (I) (E) -- (I1) (E) -- (H);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_4.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.7, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/I,2/0/O,1.6/0.8/A}
\tkzDefPointBy[homothety = center I ratio 3](A) \tkzGetPoint{A'}
\tkzDefPointBy[homothety = center I ratio 3](O) \tkzGetPoint{O'}
\tkzDrawSegments(O,A O',A')
\tkzDrawSegments[dashed](I,A' I,O')
\tkzDrawCircle[radius](O,A)
\tkzDrawCircle[radius](O',A')
\tkzDrawPoints[fill=black](I,O,O',A,A')
\tkzLabelPoints[below](O,O')
\tkzLabelPoints[above](A,A')
\tkzLabelPoints[left](I)
\path (O)--(A) node[above,midway,sloped]{$R$};
\path (O')--(A') node[above,midway,sloped]{$R'$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_5.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.7, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/I,3/0/C,2.5/2.5/A,3.5/1.5/B}
\tkzDefPointBy[homothety = center I ratio 3/2](A) \tkzGetPoint{A'}
\tkzDefPointBy[homothety = center I ratio 3/2](B) \tkzGetPoint{B'}
\tkzDefPointBy[homothety = center I ratio 3/2](C) \tkzGetPoint{C'}
\tkzDrawPolygon(A,B,C)
\tkzDrawPolygon(A',B',C')
\tkzDrawSegments[dashed](I,A' I,B' I,C')
\tkzDrawPoints[fill=black](I,A,B,C,A',B',C')
\tkzLabelPoints[below](C',C)
\tkzLabelPoints[above](A',A)
\tkzLabelPoints[right](B')
\tkzLabelPoints[left](I)
\tkzLabelPoints[below right](B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_6.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/O}
\coordinate (M) at ($(O)+(-30:1cm)$);
\coordinate (M') at ($(O)+(70:1cm)$);
\coordinate (N) at ($(O)+(-10:2cm)$);
\coordinate (N') at ($(O)+(90:2cm)$);
\tkzDrawArc[R,dashed](O,2cm)(-10,90)
\tkzDrawArc[R,dashed](O,1cm)(-30,70)
\tkzDrawPoints[size=5,fill=black](M,M',N,N',O)
\tkzDrawSegments[dashed](O,M O,N O,M' O,N')
\tkzDrawSegments[thick](M,N M',N')
\tkzLabelPoints[below](O,M,N)
\tkzLabelPoints[above](N')
\tkzLabelPoints[right](M')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_7.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoint(0,0){O}
\tkzDefPoint(2,0){E}
\tkzDefPointBy[rotation = center O angle 60](E) \tkzGetPoint{F}
\tkzDefPointBy[rotation = center O angle 120](E) \tkzGetPoint{A}
\tkzDefPointBy[rotation = center O angle 180](E) \tkzGetPoint{B}
\tkzDefPointBy[rotation = center O angle 240](E) \tkzGetPoint{C}
\tkzDefPointBy[rotation = center O angle 300](E) \tkzGetPoint{D}
\coordinate (I) at ($(A)!.5!(B)$);
\coordinate (J) at ($(C)!.5!(D)$);
\tkzDrawSegments(A,B B,C C,D D,E E,F F,A O,A O,F I,F J,B O,C O,D B,E O,I O,J E,A E,C)
\tkzDrawPolygon[draw=none,pattern=north east lines](A,I,F)
\tkzDrawPolygon[draw=none,pattern=north east lines](C,J,B)
\tkzDrawPolygon[draw=none,pattern=north west lines](O,F,A)
\tkzDrawPolygon[draw=none,pattern=north west lines](D,O,C)
\draw (A) node[above] {$A$} (B) node[left] {$B$} (C) node[below] {$C$} (D) node[below] {$D$} (E) node[right] {$E$} (F) node[above] {$F$} (O) node[below left] {$O$} (I) node[above left] {$I$} (J) node[below] {$J$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_8.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/O,3/0/N,2/2/M,4/1/P}
\tkzDrawPolygon[dashed](M,N,P)
\tkzDefPointBy[homothety = center O ratio 2](M) \tkzGetPoint{M'}
\tkzDefPointBy[homothety = center O ratio 2](N) \tkzGetPoint{N'}
\tkzDefPointBy[homothety = center O ratio 2](P) \tkzGetPoint{P'}
\tkzDrawPolygon[dashed](M',N',P')
\tkzDrawSegments(O,M' O,N' O,P')
\tkzDrawPoints[fill=black](O,M,N,P,M',N',P')
\tkzLabelPoints[below](N,N')
\tkzLabelPoints[above](M,M')
\tkzLabelPoints[right](P')
\tkzLabelPoints[left](O)
\tkzLabelPoints[above right](P)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_9.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=1, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/I,3/0/C,3.5/2.5/A}
\coordinate (B) at ($(A)!0.4!(C)$);
\tkzDefPointBy[homothety = center I ratio 1/2](A) \tkzGetPoint{A'}
\tkzDefPointBy[homothety = center I ratio 1/2](B) \tkzGetPoint{B'}
\tkzDefPointBy[homothety = center I ratio 1/2](C) \tkzGetPoint{C'}
\tkzDrawSegments(A',C' A,C)
\tkzDrawSegments[dashed](I,A I,B I,C)
\tkzDrawPoints[fill=black](I,A,B,C,A',B',C')
\tkzLabelPoints[below](C')
\tkzLabelPoints[above](A')
\tkzLabelPoints[right](A,B,C)
\tkzLabelPoints[left](I)
\tkzLabelPoints[below right](B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_10.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/O, 5/0/M};
\tkzDefPointBy[rotation = center O angle 60](M)\tkzGetPoint{M'};
\tkzDrawSegments(O,M O,M');
\tkzDrawPoints[fill=black](O,M,M');
\tkzLabelPoints[above](M');
\tkzLabelPoints[below](M);
\tkzLabelPoints[left](O);
\tkzMarkSegments[mark=||](O,M O,M');
\tkzMarkAngle[arc=l,size=5 cm,arrows=->](M,O,M');
\tkzMarkAngle[arc=l,size=0.7 cm,arrows=->](M,O,M');
\tkzLabelAngles[pos=1](M,O,M'){$\alpha$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_11.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,2/0/B,2/2/C, 0/2/D}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C B,D)
\coordinate (I) at ($(A)!0.5!(C)$);
\coordinate (M) at ($(A)!0.5!(D)$);
\coordinate (N) at ($(C)!0.5!(D)$);
\tkzDrawPoints[size=5,fill=black](A,B,C,D,I,M,N)
\tkzLabelPoints[below,font=\footnotesize](A,B)
\tkzLabelPoints[above,font=\footnotesize](C,D,N)
\tkzLabelPoints[below,font=\footnotesize](I)
\tkzLabelPoints[left,font=\footnotesize](M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_12.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
\draw[dashed] (1,0)--(6,0) node[below]{$d'$};
\draw (1,1)--(5,1) node[above]{$d$};
\tkzDefPoints{2/1/M, 4/1/N,3/0/M',5/0/N'}
\tkzDrawSegments[->](M,M' N,N')
\tkzDrawPoints[size=5,fill=black](M,N,M',N')
\tkzLabelPoints[above,font=\footnotesize](M,N))
\tkzLabelPoints[below,font=\footnotesize](M',N')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_13.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\def\a{10}
\foreach \x in {1,2,...,8}{
\draw (0-\a/2^\x,0-\a/2^\x) rectangle (0+\a/2^\x,0+\a/2^\x);
\draw [rotate around={45:(0,0)}] (0-\a*0.707/2^\x,0-\a*0.707/2^\x) rectangle (0+\a*0.707/2^\x,0+\a*0.707/2^\x);}
\node at (-5.3,0) {$A$};
\node at (5.3,0) {$C$};
\node at (0,-5.3) {$B$};
\node at (0,5.3) {$D$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_14.png",
    Code = @"\begin{tikzpicture}[scale=0.8,>=stealth, font=\footnotesize, line join=round, line cap=round]
\def\xmin{-2.5}\def\xmax{2.5}\def\ymin{-2.5}\def\ymax{2.5} 
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax); 
%\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$}; 
%\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$}; 
\clip (\xmin,\ymin) rectangle (\xmax,\ymax); 
%%%%
\def\r{4}
\coordinate (O) at (0,0); 
\foreach\n in {2,3,4,5}
{
\coordinate(A) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45)},{(2^(-\n/2))*\r*sin(-\n*45)})$); 
\coordinate(B) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-90)},{(2^(-\n/2))*\r*sin(-\n*45-90)})$); 
\coordinate(C) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-180)},{(2^(-\n/2))*\r*sin((-\n*45-180)})$); 
\coordinate(D) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-270)},{(2^(-\n/2))*\r*sin(-\n*45-270)})$); 
\fill[blue!30] (C)--(D)--($(O)+({(2^(-(\n-1)/2))*\r*cos(-(\n-1)*45-270)},{(2^(-(\n-1)/2))*\r*sin(-(\n-1)*45-270)})$)--cycle; 
\fill[pink] (A)--(B)--($(O)+({(2^(-(\n-1)/2))*\r*cos(-(\n-1)*45-90)},{(2^(-(\n-1)/2))*\r*sin(-(\n-1)*45-90)})$)--cycle; 
\draw (A)--(B)--(C)--(D)--cycle; 
}
\def\n{1}
\coordinate(A) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45)},{(2^(-\n/2))*\r*sin(-\n*45)})$); 
\coordinate(B) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-90)},{(2^(-\n/2))*\r*sin(-\n*45-90)})$); 
\coordinate(C) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-180)},{(2^(-\n/2))*\r*sin((-\n*45-180)})$); 
\coordinate(D) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-270)},{(2^(-\n/2))*\r*sin(-\n*45-270)})$); 
\draw (A)--(B)--(C)--(D)--cycle; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_15.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{-2/2/A,-4/-2/B,1/-2/C}
\tkzDefMidPoint(A,B)
\tkzGetPoint{A_1}
\tkzDefMidPoint(B,C)
\tkzGetPoint{B_1}
\tkzDefMidPoint(C,A)
\tkzGetPoint{C_1}
\tkzDefMidPoint(A_1,B_1)
\tkzGetPoint{A_2}
\tkzDefMidPoint(B_1,C_1)
\tkzGetPoint{B_2}
\tkzDefMidPoint(C_1,A_1)
\tkzGetPoint{C_2}
\tkzDefMidPoint(A_2,B_2)
\tkzGetPoint{A_3}
\tkzDefMidPoint(B_2,C_2)
\tkzGetPoint{B_3}
\tkzDefMidPoint(C_2,A_2)
\tkzGetPoint{C_3}
\tkzDrawSegments(A,B B,C C,A A_1,B_1 B_1,C_1 C_1,A_1 A_2,B_2 B_2,C_2 C_2,A_2)
\tkzDrawPoints[fill=black](A,B,C,A_1,B_1,C_1,A_2,B_2,C_2,A_3,B_3,C_3)
\tkzLabelPoints[right](C,C_1,B_2)
\tkzLabelPoints[left](A,B,A_1)
\tkzLabelPoints[below](B_1,A_2)
\tkzLabelPoints[above](C_2)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_16.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{-2/2/A,-4/-2/B,1/-2/C}
\tkzDefMidPoint(A,B)
\tkzGetPoint{A_1}
\tkzDefMidPoint(B,C)
\tkzGetPoint{B_1}
\tkzDefMidPoint(C,A)
\tkzGetPoint{C_1}
\tkzDefMidPoint(A_1,B_1)
\tkzGetPoint{A_2}
\tkzDefMidPoint(B_1,C_1)
\tkzGetPoint{B_2}
\tkzDefMidPoint(C_1,A_1)
\tkzGetPoint{C_2}
\tkzDefMidPoint(A_2,B_2)
\tkzGetPoint{A_3}
\tkzDefMidPoint(B_2,C_2)
\tkzGetPoint{B_3}
\tkzDefMidPoint(C_2,A_2)
\tkzGetPoint{C_3}
\tkzDrawSegments(A,B B,C C,A A_1,B_1 B_1,C_1 C_1,A_1 A_2,B_2 B_2,C_2 C_2,A_2)
\tkzDrawPoints(A,B,C,A_1,B_1,C_1,A_2,B_2,C_2,A_3,B_3,C_3)
\tkzLabelPoints[right](C,C_1,B_2)
\tkzLabelPoints[left](A,B,A_1)
\tkzLabelPoints[below](B_1,A_2)
\tkzLabelPoints[above](C_2)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_17.png",
    Code = @"\begin{tikzpicture}[scale=.7][>=stealth, line join=round, line cap = round]
\draw[] (0,0) -- (6,0)--(6,6)--(0,6)--(0,0);
\draw[] (3,0) -- (6,3)--(3,6)--(0,3)--(3,0);
\draw[] (1.5,1.5) -- (4.5,1.5)--(4.5,4.5)--(1.5,4.5)--(1.5,1.5);
\draw[] (1.5,3) -- (3,1.5)--(4.5,3)--(3,4.5)--(1.5,3);
\draw[] (2.25,2.25) -- (3.75,2.25)--(3.75,3.75)--(2.25,3.75)--(2.25,2.25);
\draw[] (3,2.25) -- (3.75,3)--(3,3.75)--(2.25,3)--(3,2.25);
\draw (0,0)node[left]{$A$} (6,0)node[right]{$B$} (6,6)node[above]{$C$} (0,6)node[above]{$D$};
\draw (3,0)node[below]{$A_1$} (6,3)node[right]{$B_1$} (3,6)node[above]{$C_1$} (0,3)node[left]{$D_1$};
\draw (1.5,1.5) node[below]{$A_2$} (4.4,1.3)node[right]{$B_2$} (4.7,4.3)node[above]{$C_2$} (1.6,4.7) node[left]{$D_2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_18.png",
    Code = @"\begin{tikzpicture}[scale=0.8,>=stealth, font=\footnotesize, line join=round, line cap=round]
\def\xmin{-2.5}\def\xmax{2.5}\def\ymin{-2.5}\def\ymax{2.5} 
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax); 
%\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$}; 
%\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$}; 
\clip (\xmin,\ymin) rectangle (\xmax,\ymax); 
%%%%
\def\r{4}
\coordinate (O) at (0,0); 
\foreach\n in {2,3,4}
{
\coordinate(A) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45)},{(2^(-\n/2))*\r*sin(-\n*45)})$); 
\coordinate(B) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-90)},{(2^(-\n/2))*\r*sin(-\n*45-90)})$); 
\coordinate(C) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-180)},{(2^(-\n/2))*\r*sin((-\n*45-180)})$); 
\coordinate(D) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-270)},{(2^(-\n/2))*\r*sin(-\n*45-270)})$); 
\fill[blue!30] (C)--(D)--($(O)+({(2^(-(\n-1)/2))*\r*cos(-(\n-1)*45-270)},{(2^(-(\n-1)/2))*\r*sin(-(\n-1)*45-270)})$)--cycle; 
\fill[pink] (A)--(B)--($(O)+({(2^(-(\n-1)/2))*\r*cos(-(\n-1)*45-90)},{(2^(-(\n-1)/2))*\r*sin(-(\n-1)*45-90)})$)--cycle; 
\draw (A)--(B)--(C)--(D)--cycle; 
}
\def\n{1}
\coordinate(A) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45)},{(2^(-\n/2))*\r*sin(-\n*45)})$); 
\coordinate(B) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-90)},{(2^(-\n/2))*\r*sin(-\n*45-90)})$); 
\coordinate(C) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-180)},{(2^(-\n/2))*\r*sin((-\n*45-180)})$); 
\coordinate(D) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-270)},{(2^(-\n/2))*\r*sin(-\n*45-270)})$); 
\draw (A)--(B)--(C)--(D)--cycle; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_19.png",
    Code = @"\begin{tikzpicture}[scale=0.8,>=stealth, font=\footnotesize, line join=round, line cap=round]
\def\xmin{-2.5}\def\xmax{2.5}\def\ymin{-2.5}\def\ymax{2.5} 
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax); 
%\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$}; 
%\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$}; 
\clip (\xmin,\ymin) rectangle (\xmax,\ymax); 
%%%%
\def\r{4}
\coordinate (O) at (0,0); 
\foreach\n in {2,3}
{
\coordinate(A) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45)},{(2^(-\n/2))*\r*sin(-\n*45)})$); 
\coordinate(B) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-90)},{(2^(-\n/2))*\r*sin(-\n*45-90)})$); 
\coordinate(C) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-180)},{(2^(-\n/2))*\r*sin((-\n*45-180)})$); 
\coordinate(D) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-270)},{(2^(-\n/2))*\r*sin(-\n*45-270)})$); 
\fill[blue!30] (C)--(D)--($(O)+({(2^(-(\n-1)/2))*\r*cos(-(\n-1)*45-270)},{(2^(-(\n-1)/2))*\r*sin(-(\n-1)*45-270)})$)--cycle; 
\fill[pink] (A)--(B)--($(O)+({(2^(-(\n-1)/2))*\r*cos(-(\n-1)*45-90)},{(2^(-(\n-1)/2))*\r*sin(-(\n-1)*45-90)})$)--cycle; 
\draw (A)--(B)--(C)--(D)--cycle; 
}
\def\n{1}
\coordinate(A) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45)},{(2^(-\n/2))*\r*sin(-\n*45)})$); 
\coordinate(B) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-90)},{(2^(-\n/2))*\r*sin(-\n*45-90)})$); 
\coordinate(C) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-180)},{(2^(-\n/2))*\r*sin((-\n*45-180)})$); 
\coordinate(D) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-270)},{(2^(-\n/2))*\r*sin(-\n*45-270)})$); 
\draw (A)--(B)--(C)--(D)--cycle; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_20.png",
    Code = @"\begin{tikzpicture}[scale=0.8,>=stealth, font=\footnotesize, line join=round, line cap=round]
\def\xmin{-2.5}\def\xmax{2.5}\def\ymin{-2.5}\def\ymax{2.5} 
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax); 
%\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$}; 
%\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$}; 
\clip (\xmin,\ymin) rectangle (\xmax,\ymax); 
%%%%
\def\r{4}
\coordinate (O) at (0,0); 
\foreach\n in {2}
{
\coordinate(A) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45)},{(2^(-\n/2))*\r*sin(-\n*45)})$); 
\coordinate(B) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-90)},{(2^(-\n/2))*\r*sin(-\n*45-90)})$); 
\coordinate(C) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-180)},{(2^(-\n/2))*\r*sin((-\n*45-180)})$); 
\coordinate(D) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-270)},{(2^(-\n/2))*\r*sin(-\n*45-270)})$); 
\fill[blue!30] (C)--(D)--($(O)+({(2^(-(\n-1)/2))*\r*cos(-(\n-1)*45-270)},{(2^(-(\n-1)/2))*\r*sin(-(\n-1)*45-270)})$)--cycle; 
\fill[pink] (A)--(B)--($(O)+({(2^(-(\n-1)/2))*\r*cos(-(\n-1)*45-90)},{(2^(-(\n-1)/2))*\r*sin(-(\n-1)*45-90)})$)--cycle; 
\draw (A)--(B)--(C)--(D)--cycle; 
}
\def\n{1}
\coordinate(A) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45)},{(2^(-\n/2))*\r*sin(-\n*45)})$); 
\coordinate(B) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-90)},{(2^(-\n/2))*\r*sin(-\n*45-90)})$); 
\coordinate(C) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-180)},{(2^(-\n/2))*\r*sin((-\n*45-180)})$); 
\coordinate(D) at ($(O)+({(2^(-\n/2))*\r*cos(-\n*45-270)},{(2^(-\n/2))*\r*sin(-\n*45-270)})$); 
\draw (A)--(B)--(C)--(D)--cycle; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_21.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\clip(-0.5,-0.5) rectangle (8.5,8.5);
\draw (0,0) -- (0,8) -- (8,8) -- (8,0) -- (0,0)(4,0) -- (4,6) (6,4) -- (6,7) (7,6)--(7,7.5) (0,4) -- (6,4) (4,6) -- (7,6) (6,7) -- (7.5,7) (7,7.5) -- (7.5,7.5) (7.5,7) -- (7.5,7.5);
\foreach \x in {1,2,3, ..., 8} {
\foreach \y in {1,2,3, ..., 8} {
\draw[dashed] (\x,\y) -- (\x-1,\y);
\draw[dashed] (\x,\y) -- (\x,\y-1);}}
\draw [dashed](7.5,7.5) -- (7.5,8) (7.5,7.5) -- (8,7.5);
\fill [pattern = horizontal lines] (0,0) rectangle (4,4);
\fill [pattern = horizontal lines] (4,4) rectangle (6,6);
\fill [pattern = horizontal lines] (6,6) rectangle (7,7);
\fill [pattern = horizontal lines] (7,7) rectangle (7.5,7.5);
\fill [pattern = vertical lines] (0,0) rectangle (4,4);
\fill [pattern = vertical lines] (4,4) rectangle (6,6);
\fill [pattern = vertical lines] (6,6) rectangle (7,7);
\fill [pattern = vertical lines] (7,7) rectangle (7.5,7.5);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_22.png",
    Code = @"\begin{tikzpicture}[line cap=round, line join=round,font=\footnotesize,>=stealth, scale=0.5]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A, 7/0/B}
\tkzDefSquare(A,B)\tkzGetPoints{C}{D}
\tkzDrawPolygon(A,B,C,D)
\foreach \i in {1,2,3}{
\tkzDefBarycentricPoint(A=\i,B=4-\i)\tkzGetPoint{a\i}
\tkzDrawPoints[fill=black](a\i)
}
\foreach \i in {1,2,3,4}{
\tkzDefBarycentricPoint(B=\i,C=5-\i)\tkzGetPoint{b\i}
\tkzDrawPoints[fill=black](b\i)
}
\foreach \i in {1,2,3,4,5}{
\tkzDefBarycentricPoint(C=\i,A=6-\i)\tkzGetPoint{c\i}
\tkzDrawPoints[fill=black](c\i)
}
\foreach \i in {1,2,3,4,5,6}{
\tkzDefBarycentricPoint(D=\i,A=7-\i)\tkzGetPoint{d\i}
\tkzDrawPoints[fill=black](d\i)
}
\tkzDrawPolygon(a1,b2,c3)
\tkzDrawSegments(C,A)
\tkzDrawPoints[fill=black](A,B,C,D)
\tkzLabelPoints[below](A,B)
\tkzLabelPoints[above](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_23.png",
    Code = @"\begin{tikzpicture}[>=stealth, line join=round, line cap = round,scale=0.7]
\coordinate (A) at (0,0);
\coordinate (B) at (6,0);
\coordinate (C) at (2,4);
\coordinate (C1) at ($(A)!1/5!(B)$);
\coordinate (C2) at ($(A)!2/5!(B)$);
\coordinate (C3) at ($(A)!3/5!(B)$);
\coordinate (C4) at ($(A)!4/5!(B)$);
\coordinate (A1) at ($(B)!1/4!(C)$);
\coordinate (A2) at ($(B)!2/4!(C)$);
\coordinate (A3) at ($(B)!3/4!(C)$);
\coordinate (B1) at ($(A)!1/3!(C)$);
\coordinate (B2) at ($(A)!2/3!(C)$);
\draw (A)--(B)--(C)--cycle;
\draw[fill] (C1) circle(1pt) node[below]{$C_1$};
\draw[fill] (C2) circle(1pt) node[below]{$C_2$};
\draw[fill] (C3) circle(1pt) node[below]{$C_3$};
\draw[fill] (C4) circle(1pt) node[below]{$C_4$};
\draw[fill] (B1) circle(1pt) node[left]{$B_1$};
\draw[fill] (B2) circle(1pt) node[left]{$B_2$};
\draw[fill] (A1) circle(1pt) node[right]{$A_1$};
\draw[fill] (A2) circle(1pt) node[right]{$A_2$};
\draw[fill] (A3) circle(1pt) node[right]{$A_3$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 24,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_24.png",
    Code = @"\begin{tikzpicture}[scale=0.75, font=\footnotesize, line join=round, line cap=round, >=stealth]
\clip (0,0)--(1.2,4)--(5,0)--cycle;
\foreach \x in {0,...,5}\draw (1.2,4)--(\x,0) (0,\x)--(5,\x);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 25,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_25.png",
    Code = @"\begin{tikzpicture}
\draw (0,0) grid (4,-3);
\foreach \x in {0,...,4}{
\foreach \y in {0,...,-3}{
\fill (\x,\y) circle (2pt);
}
}
\path (0,0) node[above left] {$A$}
(4,-3) node[below right] {$B$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_26.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tkzDefPoints{0/0/A,5/0/B,10/0/C,15/0/D,.5/0/A',4.5/0/B',5.5/0/B'',9.5/0/C',10.5/0/C'',14.5/0/D'}
\draw (A) node {\normalsize $A$}(B) node {\normalsize $B$}(C) node {\normalsize $C$}(D) node {\normalsize $D$};
\tkzDefPointBy[rotation = center A angle 40](A') \tkzGetPoint{A1}
\tkzDefPointBy[rotation = center A angle 20](A') \tkzGetPoint{A2}
\tkzDefPointBy[rotation = center A angle -20](A') \tkzGetPoint{A3}
\tkzDefPointBy[rotation = center A angle -40](A') \tkzGetPoint{A4}
\tkzDefPointBy[rotation = center B angle -40](B') \tkzGetPoint{B1}
\tkzDefPointBy[rotation = center B angle -20](B') \tkzGetPoint{B2}
\tkzDefPointBy[rotation = center B angle 20](B') \tkzGetPoint{B3}
\tkzDefPointBy[rotation = center B angle 40](B') \tkzGetPoint{B4}
\tkzDefPointBy[rotation = center B angle -20](B'') \tkzGetPoint{B5}
\tkzDefPointBy[rotation = center B angle 20](B'') \tkzGetPoint{B6}
\tkzDefPointBy[rotation = center C angle 20](C') \tkzGetPoint{C1}
\tkzDefPointBy[rotation = center C angle -20](C') \tkzGetPoint{C2}
\tkzDefPointBy[rotation = center C angle 40](C'') \tkzGetPoint{C3}
\tkzDefPointBy[rotation = center C angle -40](C'') \tkzGetPoint{C4}
\tkzDefPointBy[rotation = center D angle -40](D') \tkzGetPoint{D1}
\tkzDefPointBy[rotation = center D angle 40](D') \tkzGetPoint{D2}
\draw (A) circle (.5cm)(B) circle (.5cm)(C) circle (.5cm)(D) circle (.5cm);
\draw (A1) .. controls (2,1.3) and (3,1.3) .. (B1);
\draw (A2) .. controls (2,.7) and (3,.7) .. (B2);
\draw (A3) .. controls (2,-.7) and (3,-.7) .. (B3);
\draw (A4) .. controls (2,-1.3) and (3,-1.3) .. (B4);
\draw (B6) .. controls (7,.7) and (8,.7) .. (C2);
\draw (B5) .. controls (7,-.7) and (8,-.7) .. (C1);
\draw (C3) .. controls (12,1.3) and (13,1.3) .. (D1);
\draw (C4) .. controls (12,-1.3) and (13,-1.3) .. (D2);
\draw[-] (C'')--(D');
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_27.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\draw (0,0) grid (6,-4);
\foreach \x in {0,...,6}{
\foreach \y in {0,...,-4}{
\fill (\x,\y) circle (2pt);
}
}
\path (0,0) node[above left] {$A$}
(6,-4) node[below right] {$B$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_28.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
\draw[color=violet,line width=0.07pt] (0,0) grid (3,2);
\tkzDefPoints{0/0/A,1/2/B,3/1/C}
\tkzDrawSegments[color=red](A,B B,C C,A)
\tkzMarkRightAngle[size=0.3,fill=gray!20](A,B,C)
\draw[fill=blue] (0,0) circle(1.5pt) (1,0) circle(1.5pt) (2,0) circle(1.5pt) (3,0) circle(1.5pt);
\draw[fill=blue] (0,1) circle(1.5pt) (1,1) circle(1.5pt) (2,1) circle(1.5pt) (3,1) circle(1.5pt);
\draw[fill=blue] (0,2) circle(1.5pt) (1,2) circle(1.5pt) (2,2) circle(1.5pt) (3,2) circle(1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_29.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
\draw[color=violet,line width=0.07pt] (0,0) grid (3,2);
\draw[fill=blue] (0,0) circle(1.5pt) (1,0) circle(1.5pt) (2,0) circle(1.5pt) (3,0) circle(1.5pt);
\draw[fill=blue] (0,1) circle(1.5pt) (1,1) circle(1.5pt) (2,1) circle(1.5pt) (3,1) circle(1.5pt);
\draw[fill=blue] (0,2) circle(1.5pt) (1,2) circle(1.5pt) (2,2) circle(1.5pt) (3,2) circle(1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_30.png",
    Code = @"\begin{tikzpicture}[scale=0.6,>=stealth, font=\footnotesize, line join=round, line cap=round]
\draw (-1,0)--(3,0) node [above]{$d$};
\draw (0,-1)--(0,3.5) node [left]{$d'$};
\draw[fill=black] (0,0) circle (1pt);
\draw[fill=black] (0,3) circle (1pt);
\node at (0,0) [below right]{$H(a;b)$};
\node at (0,3) [right]{$M$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_31.png",
    Code = @"\begin{tikzpicture}[scale=0.8,>=stealth]
\draw(0,0)--(7,0);
\draw (0,0)circle (1pt)(7,0) circle (1pt)(3,0) circle (1pt);
\draw[->](1.5,-0.3)--(1.5,-0.7);
\draw[->](5,-0.3)--(5,-0.7);
\draw(4.5,-0.9)--(5.5,-0.9)--(5.5,-1.9)--(4.5,-1.9)--(4.5,-0.9);
\draw(1.5,-0.9)--(2,-1.9)--(1,-1.9)--(1.5,-0.9);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_32.png",
    Code = @"\begin{tikzpicture}
\path 
(0:0) coordinate (A')
(0:6) coordinate (B')
(0:2) coordinate (M)
($(A')+(90:2.5)$) coordinate (A)
($(B')+(90:3)$) coordinate (B)
;
\fill[cyan!50] (-1.5,-1) rectangle (7.5,0);
\draw[thick] (A')--node[left]{$500 \text{(m)}$}(A)--(M)--(B)--node[right]{$600 \text{(m)}$}(B');
\foreach \i/\j in{A'/-100,B'/-80,A/100,B/80,M/-90}{\fill [black](\i) circle (1pt) ($(\i)+(\j:3mm)$) node {$\i$};}
\draw [dashed,<->] (0,.6)--(6,.6) node[pos=0.75,sloped,above]{$2\,200\text{(m)}$}; %Tùy chọn sloped,above,below
\node at (3,-1.5){\it Hình 37};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 33,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_33.png",
    Code = @"\begin{tikzpicture}
\path 
(0:0) coordinate (A')
(0:6) coordinate (B')
(0:2) coordinate (M)
($(A')+(90:2.5)$) coordinate (A)
($(B')+(90:3)$) coordinate (B)
;
\draw[thick] (A')--node[left]{$500 \text{(m)}$}(A)--(M)--(B)--node[right]{$600 \text{(m)}$}(B') (A')--(B');
\foreach \i/\j in{A'/-100,B'/-80,A/100,B/80,M/-90}{\fill [black](\i) circle (1pt) ($(\i)+(\j:3mm)$) node {$\i$};}
\draw [dashed,<->] (0,.6)--(6,.6) node[pos=0.75,sloped,above]{$2\,200\text{(m)}$}; %Tùy chọn sloped,above,below
\node at (3,-1.5){\it Hình 37};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 34,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_34.png",
    Code = @"\begin{tikzpicture}[scale=0.8]
\tkzDefPoints{0/0/A,3/2/B,0/-4/A'}
\tkzDefLine[mediator](A,A') \tkzGetPoints{C}{d}
\tkzInterLL(A',B)(C,d)\tkzGetPoint{M}
\coordinate (N) at ($(M)!0.3!(C)$);
\tkzDrawPoints[fill=black](A,A',B,M)
\tkzDrawSegments(C,d A,M A',B)
\tkzDrawSegments[dashed](A,A' A,N N,B)
\tkzLabelPoints[above](A,B,d)
\tkzLabelPoints[below](A')
\tkzLabelPoints[below right](M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 35,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_35.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\draw (0,0)--(4,0) node [below]{$\Delta$};
\draw[dashed] (2,-1.5)node [below right]{$M'$}--(2,0);
\draw (2,0)node [below right]{$H$}--(2,1.5) node [right]{$M(x_0;y_0)$};
\draw[fill=black] (2,0) circle(1.5pt) (2,1.5) circle(1.5pt) (2,-1.5) circle(1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 36,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_36.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[xmin=-0.5, xmax=4.5, ymin=-0.5, ymax=2.5]
\tkzClip
\tkzDefPoints{0/0/B,1.5/2/A,4/0/C,1.2/0/M}
\tkzDefMidPoint(B,C)\tkzGetPoint{E}
\tkzDefPointBy[symmetry=center E](M)\tkzGetPoint{N}
\tkzDrawPoints[fill=black](A,B,C,E,M,N)
\tkzDrawSegments(B,C)
\draw[->] (A)--(B) (A)--(C) (A)--(M) (A)--(N) (A)--(E);
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B,C,M,N,E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 37,
    Title = "Hình minh họa Toán học",
    Category = "Hình khác",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Hinh_khac/hinhkhac_37.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,4/0/B}
\coordinate (M) at ($(A)!0.5!(B)$);
\tkzDrawPoints[size=5,fill=black](A,B,M)
\tkzDrawSegments(A,B)
\tkzLabelPoints[above](A,B,M) 
\end{tikzpicture}"
},

