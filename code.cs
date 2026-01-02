
new TikzItem2
{
    Id = 1,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_1.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzInit[ymin=-3.5,ymax=4,xmin=-1,xmax=6]
\tkzClip
\tkzDefPoints{0/0/A, 3.5/3/B, 4/-3/D, 5/0/C}
\tkzDefMidPoint(D,C)\tkzGetPoint{M}
\tkzDefMidPoint(B,A)\tkzGetPoint{N}
\tkzDrawSegments[dashed](A,C A,M M,N)
\tkzDrawPolygon(D,B,C)
\tkzDrawSegments(D,A A,B B,M)
\tkzLabelPoints[left](A,N)
\tkzLabelPoints[right](C, M)
\tkzLabelPoints[below](D)
\tkzLabelPoints[above](B)
\tkzMarkRightAngles(D,M,A B,N,M)
\tkzMarkSegments[mark=|](D,M M,C N,B N,A)
\tkzDrawPoints[fill=black](A,B,C,D,N,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_2.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,font=\footnotesize,>=stealth,scale=0.75]
\fill (0,0) coordinate [label=below:$O$] (O) circle(1pt)
(0:4) coordinate [label=below right:$C$] (C) circle(1pt)
(90:4) coordinate [label=above:$A$] (A) circle(1pt)
(-40:3) coordinate [label=below right:$B$] (B) circle(1pt)
($(B)!0.5!(C)$) coordinate [label=below right:$M$] (M) circle(1pt);
\tkzDefLine[parallel=through B](O,M)\tkzGetPoint{b}
\tkzInterLL(B,b)(O,C)\tkzGetPoint{D}
\tkzDefLine[parallel=through O](B,C)\tkzGetPoint{o}
\tkzInterLL(O,o)(B,D)\tkzGetPoint{H}
\fill($(A)!0.6!(H)$) coordinate [label=left:$K$] (K) circle(1pt);
\fill (D) node[shift={(-120:2ex)}]{$D$} circle(1pt)
(H) node[shift={(-120:2ex)}]{$H$} circle(1pt);
\draw (H)--(A)--(D)--(B)--(C)--(A)--(B);
\draw[dashed] (A)--(C)--(D) (A)--(O)--(M) (H)--(O)--(K) (B)--(O);
\tkzMarkRightAngles[size=0.2](O,H,B O,K,H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_3.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\coordinate (A) at (0,0);
\coordinate (B) at (1.2,-1.6);
\coordinate (C) at (5,0);
\coordinate (M) at ($(B)!0.5!(C)$);\coordinate (G) at ($(A)!2/3!(M)$);
\coordinate (S) at ($(G)+(0,3.3)$);
\coordinate (H) at ($(S)!0.6!(M)$);
\draw (S)--(A)--(B)--(C)--cycle (M)--(S)--(B);
\draw[dashed] (C)--(A)--(M) (S)--(G)--(H);
\foreach \p/\q in {S/90,A/180,B/-90,C/0,G/-90,M/-40,H/20}{
\path (\p) node[shift={(\q:3mm)}]{$\p$};
\fill[black] (\p) circle (1.0pt);}
\draw pic[draw=black,angle radius=0.2cm] {right angle = S--G--A};
\draw pic[draw=black,angle radius=0.2cm] {right angle = A--M--B};
\draw pic[draw=black,angle radius=0.2cm] {right angle = G--H--S};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_4.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A,1.2/-1.6/B,4.5/0/C}
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\coordinate (S) at ($(G)+(0,3)$);
\coordinate (M) at ($(B)!1/2!(C)$);
\tkzDrawPolygon(A,B,C,S)
\tkzDrawSegments(S,B S,M)
\tkzDrawSegments[dashed](M,A A,C S,G)
\tkzDrawPoints[fill=black](A,B,C,S,G,M)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B,G,M)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_5.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A,1.2/-1.6/B,4.5/0/C}
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\coordinate (S) at ($(G)+(0,3.5)$);
\coordinate (M) at ($(B)!1/2!(C)$);
\tkzDrawPolygon(A,B,C,S)
\tkzDrawSegments(S,B S,M)
\tkzDrawSegments[dashed](M,A A,C S,G)
\tkzDrawPoints[fill=black](A,B,C,S,G,M)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B,G,M)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_6.png",
    Code = @"\begin{tikzpicture}[line join=round, line cap=round, >=stealth,font=\footnotesize, scale=1]
\tkzDefPoints{0/0/A, 4/0/C, 2.5/-1.5/B}
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\tkzDefShiftPoint[G](90:4){S}
\tkzDefMidPoint(B,C)\tkzGetPoint{M}
\tkzDrawPoints[fill=black, size=3pt](A,B,C,G,S,M)
\tkzDrawSegments(S,A S,B S,C S,M A,B B,C)
\tkzDrawSegments[dashed](S,G A,C A,M G,C)
\tkzMarkSegments[mark=|, size=0.1cm](B,M C,M)
\tkzMarkRightAngles[size=0.15](S,G,A A,M,B S,M,C)
\node[above] at (S){$S$};
\node[below] at (G){$G$};
\node[below] at (B){$B$};
\node[left] at (A){$A$};
\node[right] at (C){$C$};
\node[right] at (M){$M$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_7.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round, >=stealth,scale=1]
\def \xa{1}
\def \xb{-1}
\def \y{4}
\def \z{3}
\coordinate (B) at (0,0);
\coordinate (A) at ($(B)+(\xa,\xb)$);
\coordinate (C) at ($ (B)+(\y,0) $);
\coordinate (M) at ($ (B)!0.5!(C) $);
\coordinate (G) at ($ (B)!2/3!(M) $);
\coordinate (S) at ($ (G)+(0,\z) $);
\coordinate (H) at (1.7,0);
\tkzDefMidPoint(S,A)\tkzGetPoint{K}
\draw [dashed] (B)--(C) (S)--(H) (A)--(H) (K)--(H);
\draw (S)--(B)--(A)--(S)--(C)--(A);
\tkzDrawPoints(S,A,B,C)
\tkzLabelPoints[above right](H)
\tkzLabelPoints[below right](C)
\tkzLabelPoints[above](S)
\tkzLabelPoints[above left](B,K)
\tkzLabelPoints[below left](A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_8.png",
    Code = @"\begin{tikzpicture}[scale=0.65, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/B, 6/0/C, 1.5/-2/A}
\coordinate (H) at ($(B)!.5!(C)$);
\coordinate (S) at ($(H)+(0,5)$);
\coordinate (I) at ($(B)!.5!(A)$);
\tkzDrawPoints[fill=black](A,B,C,S,H,I)
\tkzDrawSegments[dashed](S,H B,C H,I)
\tkzDrawSegments(S,C S,B S,A A,B A,C)
\tkzLabelPoints[left](A,B,I)
\tkzLabelPoints[above right](H)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](C)
\tkzMarkRightAngles(B,A,C S,H,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_9.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 6/0/C, 4/-2.5/B}
\coordinate (M) at ($(B)!.5!(C)$);
\coordinate (N) at ($(A)!.5!(B)$);
\coordinate (G) at ($(A)!.67!(M)$);
\coordinate (S) at ($(G)+(0,5)$);
\coordinate (C_1) at ($(S)!.5!(C)$);
\tkzDrawPoints[fill=black](A,B,C,S,N,G,M,C_1)
\tkzDrawSegments[dashed](M,A G,B N,C S,G A,C A,C_1)
\tkzDrawPolygon(S,A,B,C)
\tkzDrawSegments(S,B B,C_1)
\tkzLabelPoints[left](A,N)
\tkzLabelPoints[right](C,M,C_1)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B)
\tkzLabelPoints[below left](G)
\tkzMarkRightAngles(S,G,A B,C_1,C A,C_1,S)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_10.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\coordinate (D) at (-2,0);
\coordinate (B) at (-1,-2);
\coordinate (C) at (3,0);
\tkzCentroid(D,B,C) \tkzGetPoint{H}
\coordinate (A) at ($(H)+(0,4)$);
\tkzDrawSegments(A,D A,B A,C B,C D,B)
\tkzDrawSegments[dashed](D,C A,H H,D H,B H,C)
\tkzMarkRightAngles(D,H,A A,H,C)
\tkzDrawPoints[fill=black](A,D,B,C,H)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](D)
\tkzLabelPoints[below](B,H)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_11.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/B, 6/0/D, 4/-2.5/C}
\coordinate (E) at ($(C)!.5!(D)$);
\coordinate (H) at ($(B)!.67!(E)$);
\coordinate (A) at ($(H)+(0,5)$);
\tkzDrawSegments[dashed](E,B A,H B,D)
\tkzDrawPolygon(A,B,C,D)
\tkzDrawPoints[fill=black](A,B,C,D,H)
\tkzDrawSegments(A,C)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C)
\tkzLabelPoints[below left](H)
\tkzMarkRightAngle(B,H,A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_12.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/B,7/0/D,3/6/A, 2/-2/C}
\tkzDefMidPoint(A,D)\tkzGetPoint{P}
\tkzDefMidPoint(C,B)\tkzGetPoint{M}
\tkzDefMidPoint(B,D)\tkzGetPoint{N}
\tkzDefMidPoint(A,C)\tkzGetPoint{Q}
\tkzDrawPoints[fill=black](A,B,C,D,M,N,P,Q)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](Q)
\tkzLabelPoints[above right](P)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below left](M)
\tkzLabelPoints[below](C,N)
\tkzDrawSegments(A,C B,C C,D A,D A,B Q,M Q,P)
\tkzDrawSegments[dashed](D,B N,M P,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_13.png",
    Code = @"\begin{tikzpicture}[scale=.6,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/A,7/0/C,5/6/C', 5/-3/B}
\tkzDefMidPoint(B,C)\tkzGetPoint{N}
\tkzDefMidPoint(C',B)\tkzGetPoint{P}
\tkzDefMidPoint(A,C')\tkzGetPoint{Q}
\tkzDefMidPoint(A,C)\tkzGetPoint{M}
\tkzDefMidPoint(A,B)\tkzGetPoint{H}
\tkzDrawPoints[fill=black](A,B,C,C',M,N,P,Q,H)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above left](Q)
\tkzLabelPoints[above](C')
\tkzLabelPoints[right](C,P)
\tkzLabelPoints[below right](N)
\tkzLabelPoints[below left](H)
\tkzLabelPoints[below](M,B)
\tkzDrawSegments(A,C' B,C' C,C P,Q P,N C',H A,B C,B C,C')
\tkzDrawSegments[dashed](Q,M A,C C,H M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_14.png",
    Code = @"\begin{tikzpicture}[scale=.6,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/B,7/0/D,3/6/A, 2/-2/C}
\tkzDefPointBy[homothety=center C ratio 0.3333](B)\tkzGetPoint{M}
\tkzDefPointBy[homothety=center C ratio 0.3333](A)\tkzGetPoint{Q}
\tkzDefPointBy[homothety=center D ratio 0.3333](A)\tkzGetPoint{P}
\tkzDefPointBy[homothety=center D ratio 0.3333](B)\tkzGetPoint{N}
\tkzDrawPoints[fill=black](A,B,C,M,N,P,Q,D)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B)
\tkzLabelPoints[above left](Q)
\tkzLabelPoints[above right](P)
\tkzLabelPoints[right](D)
\tkzLabelPoints[below right](N)
\tkzLabelPoints[below](C)
\tkzLabelPoints[below left](M)
\tkzDrawSegments(A,B A,C A,D P,Q Q,M B,C C,D)
\tkzDrawSegments[dashed](B,D P,N M,N)
\tkzLabelSegment[pos=.5,above left](A,B){ $4$}
\tkzLabelSegment[pos=.5,below](C,D){ $6$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_15.png",
    Code = @"\begin{tikzpicture}[scale=.55,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/B,7/0/D,3/6/A, 2/-2/C}
\tkzDefPointBy[homothety=center C ratio 0.3333](B)\tkzGetPoint{M}
\tkzDefPointBy[homothety=center C ratio 0.3333](A)\tkzGetPoint{Q}
\tkzDefPointBy[homothety=center D ratio 0.3333](A)\tkzGetPoint{P}
\tkzDefPointBy[homothety=center D ratio 0.3333](B)\tkzGetPoint{N}
\tkzDrawPoints[fill=black](A,B,C,M,N,P,Q,D)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B)
\tkzLabelPoints[above left](Q)
\tkzLabelPoints[above right](P)
\tkzLabelPoints[right](D)
\tkzLabelPoints[below right](N)
\tkzLabelPoints[below](C)
\tkzLabelPoints[below left](M)
\tkzDrawSegments(A,B A,C A,D P,Q Q,M B,C C,D)
\tkzDrawSegments[dashed](B,D P,N M,N)
\tkzLabelSegment[pos=.5,above left](A,B){ $6$}
\tkzLabelSegment[pos=.5,below](C,D){ $6$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_16.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/B,7/0/D,3/6/A, 2/-2/C}
\tkzDefMidPoint(A,D)\tkzGetPoint{M}
\tkzDefMidPoint(C,B)\tkzGetPoint{N}
\tkzDefMidPoint(B,A)\tkzGetPoint{P}
\tkzDrawPoints[fill=black](A,B,C,D,M,N,P)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above left](P)
\tkzLabelPoints[above right](M)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below left](N)
\tkzLabelPoints[below](C)
\tkzDrawSegments(A,C B,C C,D A,D A,B P,N)
\tkzLabelSegment[pos=.5,left](A,C){$a$}
\tkzLabelSegment[pos=.7,above](B,D){$3a$}
\tkzDrawSegments[dashed](D,B P,M M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_17.png",
    Code = @"\begin{tikzpicture}[scale=.6,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/B,7/0/D,3/6/A, 2/-2/C}
\tkzDefMidPoint(A,D)\tkzGetPoint{F}
\tkzDefMidPoint(C,B)\tkzGetPoint{J}
\tkzDefMidPoint(C,A)\tkzGetPoint{I}
\tkzDefMidPoint(D,B)\tkzGetPoint{E}
\tkzDrawPoints[fill=black](A,B,C,I,J,E,F)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above left](I)
\tkzLabelPoints[above right](F)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below left](J)
\tkzLabelPoints[below](C,E)
\tkzDrawSegments(A,C B,C C,D A,D A,B I,F I,J)
\tkzDrawSegments[dashed](D,B E,J E,F E,I J,F)
\tkzMarkSegments[color=black,
pos=0.6,mark=||](A,B C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_18.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3.1,ymax=7.1,xmin=-1.1,xmax=8.1]
\tkzClip
\tkzDefPoints{0/0/B,7/0/D,3/6/A, 2/-2/C}
\tkzDefMidPoint(A,B)\tkzGetPoint{I}
\tkzDefMidPoint(C,D)\tkzGetPoint{J}
\tkzDrawPoints[fill=black](A,B,C,D,I,J)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above left](I)
\tkzLabelPoints[below right](J)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](C)
\tkzDrawSegments(A,C B,C C,D A,D A,B I,C)
\tkzDrawSegments[dashed](D,B I,J I,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_19.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3.1,ymax=7.1,xmin=-1.1,xmax=8.1]
\tkzClip
\tkzDefPoints{0/0/B,7/0/D,3/5/A, 2/-2/C}
\tkzDefMidPoint(A,B)\tkzGetPoint{I}
\tkzDefMidPoint(C,D)\tkzGetPoint{J}
\tkzDrawPoints[fill=black](A,B,C,D,I,J)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above left](I)
\tkzLabelPoints[below right](J)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](C)
\tkzDrawSegments(A,C B,C C,D A,D A,B I,C)
\tkzDrawSegments[dashed](D,B I,J I,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_20.png",
    Code = @"\begin{tikzpicture}[scale=.4,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3.2,ymax=7.2,xmin=-1.2,xmax=8.2]
\tkzClip
\tkzDefPoints{0/0/A,7/0/C,3/5/S, 2/-2/B}
\tkzDrawPoints[fill=black](A,B,C,S)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B)
\tkzLabelPoints[right](C)
\tkzDrawSegments(A,B B,C S,A S,B S,C)
\tkzDrawSegments[dashed](A,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](S,B)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,S)
\tkzMarkSegment[color=black,
pos=0.6,mark=|](A,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=|](B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_21.png",
    Code = @"\begin{tikzpicture}[scale=.4,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3.2,ymax=7.2,xmin=-1.2,xmax=8.2]
\tkzClip
\tkzDefPoints{0/0/A,7/0/C,3/6/S, 2/-2/B}
\tkzDrawPoints[fill=black](A,B,C,S)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B)
\tkzLabelPoints[right](C)
\tkzDrawSegments(A,B B,C S,A S,B S,C)
\tkzDrawSegments[dashed](A,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](S,B)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,S)
\tkzMarkSegment[color=black,
pos=0.6,mark=|](A,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=|](B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_22.png",
    Code = @"\begin{tikzpicture}[scale=.4,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3.2,ymax=7.2,xmin=-1.2,xmax=8.2]
\tkzClip
\tkzDefPoints{0/0/A,7/0/B,3/6/S, 2/-2/C}
\tkzDrawPoints[fill=black](A,B,C,S)
\tkzLabelPoints[above](S)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](B)
\tkzLabelPoints[below](C)
\tkzDrawSegments(A,C B,C S,A S,B S,C)
\tkzDrawSegments[dashed](A,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_23.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3.2,ymax=7.2,xmin=-1.2,xmax=8.2]
\tkzClip
\tkzDefPoints{0/0/C,7/0/D,3/6/A, 2/-2/B}
\tkzDrawPoints[fill=black](A,B,C,D)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](C)
\tkzDrawSegments(A,B A,C A,D B,C B,D)
\tkzDrawSegments[dashed](D,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,D)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](D,C)
\tkzMarkAngles[draw=red](C,A,B)
\tkzMarkAngle[size =0.6,
mksize=3](B,A,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 24,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_24.png",
    Code = @"\begin{tikzpicture}[scale=.4,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3.2,ymax=7.2,xmin=-1.2,xmax=8.2]
\tkzClip
\tkzDefPoints{0/0/A,7/0/C,3/6/S, 2/-2/B}
\tkzDrawPoints[fill=black](A,B,C,S)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B)
\tkzLabelPoints[right](C)
\tkzDrawSegments(A,B B,C S,A S,B S,C)
\tkzDrawSegments[dashed](A,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](S,B)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](S,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,S)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 25,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_25.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3.2,ymax=7.2,xmin=-1.2,xmax=8.2]
\tkzClip
\tkzDefPoints{0/0/A,7/0/C,3/5/S, 2/-2/B}
\tkzDrawPoints[fill=black](A,B,C,S)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B)
\tkzLabelPoints[right](C)
\tkzDrawSegments(A,B B,C S,A S,B S,C)
\tkzDrawSegments[dashed](A,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](S,B)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](S,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,S)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_26.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/C,7/0/D,3/6/A, 2/-2/B}
\tkzDrawPoints[fill=black](A,B,C,D)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](C)
\tkzDrawSegments(A,B A,C A,D B,C B,D)
\tkzDrawSegments[dashed](D,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,D)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,B)
\tkzMarkAngles[draw=red](C,A,B)
\tkzMarkAngle[size =0.7,
mksize=3](B,A,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_27.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/C,7/0/D,3/5/A, 2/-2/B}
\tkzDrawPoints[fill=black](A,B,C,D)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](C)
\tkzDrawSegments(A,B A,C A,D B,C B,D)
\tkzDrawSegments[dashed](D,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,D)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,C)
\tkzMarkSegment[color=black,
pos=0.6,mark=||](A,B)
\tkzMarkAngles[draw=red](C,A,B)
\tkzMarkAngle[size =0.7,
mksize=3](B,A,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_28.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\coordinate (B) at (121:5 and 1.5);
\coordinate (C) at (-110:5 and 1.5);
\coordinate (D) at (15:5 and 1.5);
\tkzDefMidPoint(C,D)\tkzGetPoint{M}
\tkzDefMidPoint(C,B)\tkzGetPoint{N}
\tkzInterLL(B,M)(D,N)\tkzGetPoint{O}
\coordinate (A) at ($(O)+(0,6)$);
\tkzDrawPoints[fill=black](A,B,C,D,M,O)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below left](B)
\tkzLabelPoints[below right](M)
\tkzLabelPoints[right](D)
\tkzLabelPoints[below left](C,O)
\tkzDrawSegments(A,B A,C A,D B,C C,D A,M)
\tkzDrawSegments[dashed](D,B B,M D,N A,O)
\draw (B) arc (121:375:5 and 1.5);
\draw[dashed] (D) arc (15:121:5 and 1.5);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_29.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\coordinate (B) at (121:5 and 1.5);
\coordinate (C) at (-110:5 and 1.5);
\coordinate (D) at (15:5 and 1.5);
\tkzDefMidPoint(C,D)\tkzGetPoint{M}
\tkzDefMidPoint(C,B)\tkzGetPoint{N}
\tkzInterLL(B,M)(D,N)\tkzGetPoint{O}
\coordinate (A) at ($(O)+(0,6)$);
\tkzDrawPoints[fill=black](A,B,C,D,M,O)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below left](B)
\tkzLabelPoints[below right](M)
\tkzLabelPoints[right](D)
\tkzLabelPoints[below left](C,O)
\tkzDrawSegments(A,B A,C A,D B,C C,D A,M)
\tkzDrawSegments[dashed](D,B B,M D,N A,O)
\draw (B) arc (121:375:5 and 1.5);
\draw[dashed] (D) arc (15:121:5 and 1.5);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_30.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/B,7/0/D,3/5/A, 2/-2/C}
\tkzDefMidPoint(B,C)\tkzGetPoint{M}
\tkzDrawPoints[fill=black](A,B,C,D,M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D)
\tkzLabelPoints[below left](M)
\tkzLabelPoints[below](C)
\tkzDrawSegments(A,B A,M A,C A,D D,C B,C)
\tkzDrawSegments[dashed](M,D D,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_31.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/B,7/0/D,3/6/A, 2/-2/C}
\tkzDefMidPoint(B,C)\tkzGetPoint{M}
\tkzDrawPoints[fill=black](A,B,C,D,M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D)
\tkzLabelPoints[below left](M)
\tkzLabelPoints[below](C)
\tkzDrawSegments(A,B A,M A,C A,D D,C B,C)
\tkzDrawSegments[dashed](M,D D,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_32.png",
    Code = @"\begin{tikzpicture}[scale=.4,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3.1,ymax=7.1,xmin=-1.1,xmax=8.1]
\tkzClip
\tkzDefPoints{0/0/B,7/0/C,3/6/A, 2/-2/D}
\tkzDefMidPoint(D,C)\tkzGetPoint{M}
\tkzDrawPoints[fill=black](A,B,C,D,M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below left](B,D)
\tkzLabelPoints[below](M)
\tkzLabelPoints[right](C)
\tkzDrawSegments(A,B A,M A,C A,D B,D D,C)
\tkzDrawSegments[dashed](M,B C,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 33,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_33.png",
    Code = @"\begin{tikzpicture}[scale=.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/B,7/0/C,3/5/A, 2/-2/D}
\tkzDrawPoints[fill=black](A,B,C,D)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below left](B,D)
\tkzLabelPoints[right](C)
\tkzDrawSegments(A,B A,C A,D B,D D,C)
\tkzDrawSegments[dashed](C,B)
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=34): PDF có nhưng không tạo được PNG

new TikzItem2
{
    Id = 35,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_35.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[ymin=-3,ymax=7,xmin=-1,xmax=8]
\tkzClip
\tkzDefPoints{0/0/B,7/0/D,3/6/A, 2/-2/C}
\tkzCentroid(D,B,C)\tkzGetPoint{G}
\tkzDefMidPoint(C,D)\tkzGetPoint{M}
\tkzDrawPoints[fill=black](A,B,C,D,M,G)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](M)
\tkzLabelPoints[right](D)
\tkzLabelPoints[below](G)
\tkzLabelPoints[below](C)
\tkzDrawSegments(A,B B,C A,C A,D C,D)
\tkzDrawSegments[dashed](B,C B,D G,A B,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 36,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_36.png",
    Code = @"\begin{tikzpicture}[scale=.6, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A, 6/0/B, 2/-3/C, 2.5/4/S}
\draw (A)node[left]{$A$} circle (1pt);
\draw (B) node[right]{$B$} circle (1pt);
\draw (C) node[below]{$C$} circle (1pt);
\draw (S) node[above]{$S$} circle (1pt);
\tkzDrawPolygon(S,A,C)
\draw (C)--(B)--(S);
\draw[dashed](A)--(B);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 37,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_37.png",
    Code = @"\begin{tikzpicture}[scale=.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A, 7/0/B, 5/-3/C}
\coordinate (M) at ($(B)!0.5!(C)$);
\tkzDefPointBy[homothety=center A ratio 0.6](M)\tkzGetPoint{G}
\coordinate (S) at ($(G)+(0,5)$);
\draw (A) node[left]{$A$} circle (1pt);
\draw (B) node[right]{$B$} circle (1pt);
\draw (C) node[below]{$C$} circle (1pt);
\draw (M) node[below right]{$M$} circle (1pt);
\draw (G) node[below]{$G$} circle (1pt);
\draw (S) node[above]{$S$} circle (1pt);
\tkzDrawPolygon(S,B,C)
\draw (C)--(A)--(S)--(M);
\draw[dashed](S)--(G) (B)--(A)--(M);
\tkzMarkRightAngle(S,G,M)
\tkzMarkAngle[size=0.6cm](S,M,A)
\tkzLabelAngle[pos=1.2](S,M,A){$60^\circ$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 38,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_38.png",
    Code = @"\begin{tikzpicture}[scale=.6, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/B, 8/0/D, 2/-3/C, 2.5/4/A}
\coordinate (I) at ($(B)!0.5!(C)$);
\coordinate (J) at ($(A)!0.5!(D)$);
\coordinate (M) at ($(A)!0.5!(C)$);
\draw (A)node[above]{$A$} circle (1pt);
\draw (B) node[left]{$B$} circle (1pt);
\draw (C) node[below]{$C$} circle (1pt);
\draw (D) node[right]{$D$} circle (1pt);
\draw (I) node[left]{$I$} circle (1pt);
\draw (J) node[above right]{$J$} circle (1pt);
\draw (M) node[above left]{$M$} circle (1pt);
\tkzDrawPolygon(D,A,C)
\draw (C)--(B)--(A) (I)--(M)--(J);
\draw[dashed](D)--(B) (I)--(J);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 39,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_39.png",
    Code = @"\begin{tikzpicture}[scale=.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/B, 8/0/D, 6/-3/C}
\coordinate (E) at ($(B)!0.5!(C)$);
\tkzDefPointBy[homothety=center D ratio 0.6](E)\tkzGetPoint{H}
\coordinate (A) at ($(H)+(0,5)$);
\draw (A) node[above]{$A$} circle (1pt);
\draw (B) node[left]{$B$} circle (1pt);
\draw (C) node[below]{$C$} circle (1pt);
\draw (D) node[right]{$D$} circle (1pt);
\draw (E) node[below left]{$E$} circle (1pt);
\draw (H) node[below]{$H$} circle (1pt);
\tkzDrawPolygon(A,D,C)
\draw (C)--(B)--(A)--(E);
\draw[dashed](A)--(H) (E)--(D)--(B);
\tkzMarkRightAngles(A,H,E D,E,C A,E,B)
\tkzMarkAngle[size=0.6cm](H,E,A)
\tkzMarkAngle[size=0.6cm,mark=|](A,D,H)
\tkzLabelAngle[pos=1.2](H,E,A){$60^\circ$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 40,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_40.png",
    Code = @"\begin{tikzpicture}[scale=.6, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A, 6/0/B, 2/-3/C, 2.5/4/D}
\coordinate (M) at ($(A)!0.5!(D)$);
\coordinate (N) at ($(B)!0.5!(C)$);
\draw (A)node[left]{$A$} circle (1pt);
\draw (B) node[right]{$B$} circle (1pt);
\draw (C) node[below]{$C$} circle (1pt);
\draw (D) node[above]{$D$} circle (1pt);
\draw (M) node[above left]{$M$} circle (1pt);
\draw (N) node[below right]{$N$} circle (1pt);
\tkzDrawPolygon(D,A,C)
\draw (C)--(B)--(D);
\draw[dashed](A)--(B) (M)--(N);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 41,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_41.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A, 2/-2/B, 6/0/C}
\coordinate (M) at ($(B)!.5!(C)$);% M là trung điểm BC
\coordinate (G) at ($(A)!.67!(M)$);
\coordinate (S) at ($(G)+(0,5)$);
\coordinate (N) at ($(B)!.5!(A)$); 
\coordinate (H) at ($(S)!.7!(M)$); 
\tkzDefPointBy[translation= from M to C](H)
\tkzGetPoint{X}
\tkzInterLL(H,X)(S,C)\tkzGetPoint{F}
\tkzInterLL(H,X)(S,B)\tkzGetPoint{E}
\tkzDrawPoints[fill=black](A,B,C,S,E,F,G,H,M,N)
\tkzDrawSegments[dashed](A,C S,G A,M M,N G,E G,F G,H)
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(S,A A,B S,N S,M E,F) 
\tkzLabelPoints[left](A,E)
\tkzLabelPoints[right](C, M,F,G)
\tkzLabelPoints[below](B,N)
\tkzLabelPoints[below right](H)
\tkzLabelPoints[above](S)
\tkzMarkRightAngle(M,G,S)
\tkzMarkRightAngle(B,M,A)
\tkzMarkSegments[mark=|](B,M M,C)
\tkzMarkSegments[mark=||](B,N N,A)
\draw(S) circle (1pt) ;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 42,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_42.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A, 4/0/C, 3/-2/B, 0/4/E}
\tkzDefMidPoint(B,C)\tkzGetPoint{M}
\tkzDefPointBy[homothety = center A ratio 0.66](M) \tkzGetPoint{G}
\tkzDefPointBy[translation=from A to E](G) \tkzGetPoint{S}
\tkzDefPointBy[homothety = center S ratio 0.5](A) \tkzGetPoint{N}
\tkzDrawSegments(A,B C,B S,A S,C S,B S,M)
\tkzDrawSegments[dashed](A,C A,M S,G M,N)
\tkzLabelPoints(C,B,M)
\tkzLabelPoints[above](S)
\tkzLabelPoints[left](A,N)
\tkzLabelPoints[below](G)
\tkzMarkRightAngles(A,N,M A,M,B)
\tkzDrawPoints[fill=black](S,A,B,C,G,M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 43,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_43.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tkzDefPoints{0/0/A,5/-1.5/B, 8/0/C, 4/6/S}
\coordinate (M) at ($(C)!0.5!(B)$);
\tkzDrawSegments(S,A S,C S,B A,B C,B S,M)
\tkzDrawSegments[dashed](A,C A,M)
\tkzDrawPoints(A,B,C,S,M)
\tkzLabelPoints[above left](A)
\tkzLabelPoints[above right](C)
\tkzLabelPoints[below right](B,M)
\tkzLabelPoints[above](S)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 44,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_44.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoint(0,0){B}
\tkzDefShiftPoint[B](0:5){D}
\tkzDefShiftPoint[B](-60:2){C}
\tkzDefShiftPoint[B](60:4){A}
\tkzDefMidPoint(B,C) \tkzGetPoint{M}
\tkzDefMidPoint(A,D) \tkzGetPoint{N}
\tkzDefMidPoint(A,C) \tkzGetPoint{P}
\tkzDrawSegments(A,B A,C A,D B,C C,D M,C M,P N,P)
\tkzDrawSegments[dashed](B,D M,N)
\tkzDrawPoints(A,B,C,D,M,N,P)
\tkzLabelSegment[above left](A,B){$2a$}
\tkzLabelSegment[below right](C,D){$2a$}
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](C)
\tkzLabelPoints[above right](N)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](M)
\tkzLabelPoints[above left](P)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 45,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_45.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoint(0,0){B}
\tkzDefShiftPoint[B](0:5){D}
\tkzDefShiftPoint[B](-60:2){C}
\tkzDefShiftPoint[B](60:4){A}
\tkzDefMidPoint(B,C) \tkzGetPoint{P}
\tkzDefMidPoint(A,D) \tkzGetPoint{N}
\tkzDefMidPoint(A,C)\tkzGetPoint{E}
\tkzDefMidPoint(B,D)\tkzGetPoint{F}
\coordinate (G) at ($(B)!0.67!(N)$);
\coordinate (M) at ($(A)!0.33!(C)$);
\tkzDrawSegments(A,B A,C A,D B,C C,D E,P E,N)
\tkzDrawSegments[dashed](B,D N,P M,G A,F E,F N,F F,P)
\tkzDrawPoints(A,B,C,D,M,N,P,G,E,F)
\tkzLabelSegment[above left](A,B){$2a$}
\tkzLabelSegment[below right](C,D){$2a$}
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](C)
\tkzLabelPoints[above right](N)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](M)
\tkzLabelPoints[below left](P)
\tkzLabelPoints[above right,yshift=5pt](G)
\tkzLabelPoints[above left](E)
\tkzLabelPoints[below](F)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 46,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_46.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoints{0/0/A,2/-1.5/B,5/0/C,3/4/S}
\coordinate (M) at ($(S)!0.5!(A)$);
\coordinate (N) at ($(A)!0.5!(B)$);
\coordinate (P) at ($(B)!0.5!(C)$);
\coordinate (E) at ($(S)!0.5!(C)$);
\tkzInterLL(B,E)(S,P)\tkzGetPoint{G}
\tkzDrawSegments(S,A S,B S,C A,B B,C M,N S,P)
\tkzDrawSegments[dashed,line width=1](A,C N,P M,P A,P A,G)
\tkzDrawPoints(S,A,B,C,M,N,P,G)
\tkzLabelPoints(B,C,P,G)
\tkzLabelPoints[left](S,A,M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 47,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_47.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tkzDefPoints{0/0/B,2/-1.5/C,5/0/D,3/5/A}
\coordinate (M) at ($(A)!0.25!(B)$);
\coordinate (N) at ($(A)!0.25!(D)$);
\tkzDrawSegments(A,B A,C A,D B,C C,D C,M C,N)
\tkzDrawSegments[dashed,line width=1](B,D M,N)
\tkzDrawPoints(A,B,C,M,N,D)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D,N)
\tkzLabelPoints[left](A,M)
\tkzLabelPoints[below](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 48,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_48.png",
    Code = @"\begin{tikzpicture}[scale=1.0]
\tkzDefPoints{0/0/B, 1.5/-1.5/C, 5/0/D}
\coordinate (I) at ($(D)!0.4!(C)$);
\coordinate (H) at ($(B)!0.65!(I)$); % H thoa man SH=0.4SB
\coordinate (A) at ($(H)+(0,3.5)$);
\coordinate (K) at ($(A)!0.5!(B)$);
\tkzDrawSegments[dashed](B,D B,I K,I)
\tkzDrawSegments(A,B B,C C,D D,A A,C A,I)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B,K)
\tkzLabelPoints[right](D)
\tkzLabelPoints[below](C)
\tkzLabelPoints[below](I)
\tkzMarkRightAngle(A,K,I)
\tkzDrawPoints(A,B,C,D,K,I)
\tkzMarkSegments[mark=||](K,A K,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 49,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_49.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tkzDefPoints{0/0/A,2/-1.5/B,5/0/C,3/4/S}
\tkzDefMidPoint(B,C)\tkzGetPoint{M}
\tkzDefMidPoint(S,B)\tkzGetPoint{N}
\tkzDefMidPoint(S,C)\tkzGetPoint{P}
\tkzDrawSegments(S,A S,B S,C A,B B,C N,P)
\tkzDrawSegments[dashed](A,C A,M)
\tkzDrawPoints[fill=black](A,B,C,S,M,N,P)
\tkzMarkSegments[mark=||](A,B A,C)
\tkzMarkSegments[mark=|](S,N N,B S,P P,C)
\tkzMarkSegments[mark=x](B,M M,C)
\tkzMarkRightAngle(A,M,B)
\tkzLabelPoints[left](A)
\tkzLabelPoints[below](B)
\tkzLabelPoints[right](C)
\tkzLabelPoints[above](S)
\tkzLabelPoints(M,N)
\tkzLabelPoints[right](P)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 50,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_50.png",
    Code = @"\begin{tikzpicture}[scale=1.0]
\tkzDefPoints{0/0/A, 1.5/-1.5/B, 5/0/C}
\coordinate (H) at ($(A)!0.5!(C)$);
\coordinate (S) at ($(H)+(0,3.5)$);
\tkzDrawSegments[dashed](A,C S,H B,H)
\tkzDrawSegments(A,B B,C S,A S,B S,C)
\tkzLabelPoints[above](S)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](C)
\tkzLabelPoints[below](B)
\tkzLabelPoints[below right](H)
\tkzMarkRightAngle(A,B,C)
\tkzDrawPoints[fill=black](A,B,C,S,H)
\tkzMarkSegments[mark=||](H,A H,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 51,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_51.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/B, 3/-2/C, 8/0/D}
\coordinate (A) at ($(B)+(1,7)$);
\coordinate (M) at ($(B)!0.5!(C)$);
\coordinate (N) at ($(A)!0.5!(D)$);
\coordinate (I) at ($(A)!0.5!(C)$);
\tkzDrawSegments[dashed](B,D M,N)
\tkzDrawPoints[fill=black](A,B,C,D,M,I,N)
\tkzDrawPolygon(A,C,D)
\tkzDrawSegments(A,B B,C M,I I,N)
\tkzLabelPoints[left](B,I)
\tkzLabelPoints[right](D,N)
\tkzLabelPoints[below](C)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below left](M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 52,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_52.png",
    Code = @"\begin{tikzpicture}
\draw [line width=0.8pt] (1.62,2.52)-- (-1.,0.) (1.,-2.)-- (-1.,0.) (1.,-2.)-- (4.,0.) (1.62,2.52)-- (4.,0.) (1.62,2.52)-- (1.,-2.) (1.62,2.52)-- (0.,-1.) (2.44,1.64)-- (2.037,-1.3);
\draw [line width=0.8pt,dash pattern=on 5pt off 5pt] (4.,0.)-- (-1.,0.) (0.,-1.)-- (4.,0.) (0.72,0.)-- (2.037,-1.3) (0.729,0.)-- (2.44,1.648) (2.44,1.64)-- (1.38,-0.65);
\begin{scriptsize}
\draw[color=black] (1.62,2.81) node {$A$}
(-1.32,-0.03) node {$B$} (0.92,-2.19) node {$C$}
(4.14,0.21) node {$D$} (1.32,-0.9) node {$G$}
(0.6,-0.15) node {$H$} (2.18,-1.47) node {$I$}
(-0.22,-1.01) node {$J$} (2.58,1.93) node {$K$};
\end{scriptsize}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 53,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_53.png",
    Code = @"\begin{tikzpicture} [scale=1]
\tkzDefPoints{1/3/A, -2/0/B, 2/-2/C, 3/0/D}
\tkzDefMidPoint(A,B) \tkzGetPoint{M}
\tkzDefMidPoint(C,D) \tkzGetPoint{N}
\tkzDefMidPoint(A,C) \tkzGetPoint{P}
\tkzDefMidPoint(D,B) \tkzGetPoint{Q}
\tkzDrawSegments(A,B B,C C,D D,A M,P P,N A,C)
\tkzDrawSegments[dashed](M,N M,Q Q,P D,B Q,N)
\tkzLabelPoints[below](Q,C)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D,N)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above right=-4pt](P)
\tkzLabelPoints[above left=-4pt](M)
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=54): PDF có nhưng không tạo được PNG

new TikzItem2
{
    Id = 55,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_55.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\tkzDefPoints{0/0/S,6/0/B,-2/-2/C,0/7/A}
\coordinate (M) at ($(B)!0.5!(C)$);
\coordinate (N) at ($(A)!0.5!(C)$);
\tkzDrawSegments[line width=1](A,B A,C B,C M,N)
\tkzDrawSegments[dashed,line width=1](S,A S,B S,C S,M S,N)
\tkzDrawPoints[fill=black](S,A,B,C,M,N)
\tkzLabelPoints[below](B,C,M)
\tkzLabelPoints[left](S,A,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 56,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_56.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoints{0/0/A,4/0/B,3/-1.5/C,1.5/-1.5/D,1.5/3/S}
\coordinate (N) at ($(S)!0.5!(A)$);
\coordinate (M) at ($(S)!0.5!(B)$);
\coordinate (I) at ($2*(M)-(A)$);
\tkzInterLL(A,D)(B,C) \tkzGetPoint{E}
\tkzInterLL(S,C)(D,I) \tkzGetPoint{P}
\tkzInterLL(S,B)(D,I) \tkzGetPoint{m}
\draw (S)--(A)--(E)--(B) (S)--(C) (S)--(D)--(I)--(S) (B)--(m) (E)--(P);
\draw[dashed] (I)--(A)--(B) (C)--(D) (N)--(M)--(P) (S)--(m);
\tkzDrawPoints(A,B,C,D,E,M,N,P,S,I)
\tkzLabelPoints[above](S,I,M)
\tkzLabelPoints[right](B,C,P)
\tkzLabelPoints[left](A,N)
\tkzLabelPoints[below left=-0.1](D,E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 57,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_57.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tkzDefPoints{1/3/A, 0/0/B, 2/-2/C, 5/0/D}
\tkzCentroid(A,B,D)\tkzGetPoint{G}
\coordinate (M) at ($(B)!.5!(D)$);
\coordinate (Q) at ($(A)!.67!(B)$);
\coordinate (P) at ($(A)!.5!(B)$);
\tkzDrawSegments[dashed](A,M B,D Q,G P,D)
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C)
\tkzLabelPoints[left](B,P,Q)
\tkzLabelPoints[right](D)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](M,C)
\tkzLabelPoints[above right](G)
\tkzDrawPoints(A,B,C,D,M,P,Q,G)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 58,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_58.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tkzDefPoints{1/3/A, 0/0/B, 3/-2/D, 5/0/C}
\coordinate (Q) at ($(D)!.7!(B)$);
\coordinate (N) at ($(C)!.7!(A)$);
\coordinate (P) at ($(D)!.7!(A)$);
\coordinate (M) at ($(C)!.7!(B)$);
\coordinate (H) at ($(M)!.7!(N)$);
\tkzDrawSegments[dashed](B,C M,N Q,M)
\tkzDrawPolygon(A,B,D,C)
\tkzDrawSegments(A,D P,Q N,P)
\tkzLabelPoints[left](B,P)
\tkzLabelPoints[right](N,C,H)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](D,M)
\tkzLabelPoints[below left](Q)
\tkzDrawPoints(H)
\tkzDrawPoints(A,B,C,D,M,N,P,Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 59,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_59.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tkzDefPoints{1/3/A, 0/0/B, 2/-2/C, 5/0/D}
\coordinate (K) at ($(D)!.33!(B)$);
\coordinate (H) at ($(C)!.33!(A)$);
\coordinate (I) at ($(D)!.33!(A)$);
\coordinate (J) at ($(C)!.33!(B)$);
\tkzDrawSegments[dashed](B,D J,K I,K)
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C J,H H,I)
\tkzLabelPoints[left](B,H)
\tkzLabelPoints[right](D,I)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,K)
\tkzLabelPoints[below left](J)
\tkzDrawPoints(A,B,C,D,H,I,J,K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 60,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_60.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.5/-1.8/C,4/0/D,2/3/A}
\coordinate (M) at ($(A)!0.3!(B)$);
\coordinate (N) at ($(A)!0.6!(B)$);
\coordinate (P) at ($(C)!0.3!(D)$);
\coordinate (Q) at ($(C)!0.6!(D)$);
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,P A,C)
\tkzDrawSegments[dashed](B,D B,P N,Q M,P)
\tkzDrawPoints[fill=black](M,A,B,C,D,N,P,Q)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D)
\tkzLabelPoints[above left](M,N)
\tkzLabelPoints[below right](P,Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 61,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_61.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/C,1.5/-1.8/B,4/0/D,2/3/A}
\tkzDefMidPoint(A,C)\tkzGetPoint{J}
\tkzDefMidPoint(D,A)\tkzGetPoint{I}
\tkzCentroid(D,B,C)\tkzGetPoint{G}
\tkzDefLine[parallel=through G](D,C)\tkzGetPoint{g}
\tkzInterLL(g,G)(C,B)\tkzGetPoint{E}
\tkzInterLL(g,G)(D,B)\tkzGetPoint{F}
\tkzDrawPolygon(A,C,B,D)
\tkzDrawSegments(A,B)
\tkzDrawSegments[dashed](C,D I,J E,F)
\tkzDrawPoints[fill=black](I,A,B,C,D,J,G)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B,G)
\tkzLabelPoints[left](C,J)
\tkzLabelPoints[right](D,I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 62,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_62.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=0.75cm,y=0.75cm]
\draw (0.0,-0.0)-- (2.0,-2.0);
\draw (2.0,-2.0)-- (5.0,0.0);
\draw (5.0,0.0)-- (3.0,3.0);
\draw (3.0,3.0)-- (0.0,-0.0);
\draw (3.0,3.0)-- (2.0,-2.0);
%\draw [dash pattern=on 2pt off 2pt] (1.5,1.5)-- (3.5,-1.0);
\draw [dash pattern=on 2pt off 2pt] (0.0,-0.0)-- (5.0,0.0);
\begin{scriptsize}
\draw [fill=black] (0.0,-0.0) circle (1pt);
\draw[color=black] (-0.06,0.2) node {$B$};
\draw [fill=black] (2.0,-2.0) circle (1pt);
\draw[color=black] (1.7,-1.95) node {$C$};
\draw [fill=black] (5.0,0.0) circle (1pt);
\draw[color=black] (5.07,0.15) node {$D$};
\draw [fill=black] (3.0,3.0) circle (1pt);
\draw[color=black] (3.2,3.0) node {$A$};
\end{scriptsize}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 63,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_63.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=0.75cm,y=0.75cm]
\draw (0.0,-0.0)-- (2.0,-2.0);
\draw (2.0,-2.0)-- (5.0,0.0);
\draw (5.0,0.0)-- (3.0,3.0);
\draw (3.0,3.0)-- (0.0,-0.0);
\draw (3.0,3.0)-- (2.0,-2.0);
%\draw [dash pattern=on 2pt off 2pt] (1.5,1.5)-- (3.5,-1.0);
\draw [dash pattern=on 2pt off 2pt] (0.0,-0.0)-- (5.0,0.0);
\begin{scriptsize}
\draw [fill=black] (0.0,-0.0) circle (1pt);
\draw[color=black] (-0.06,0.2) node {$B$};
\draw [fill=black] (2.0,-2.0) circle (1pt);
\draw[color=black] (1.7,-1.95) node {$C$};
\draw [fill=black] (5.0,0.0) circle (1pt);
\draw[color=black] (5.07,0.15) node {$D$};
\draw [fill=black] (3.0,3.0) circle (1pt);
\draw[color=black] (3.2,3.0) node {$A$};
\end{scriptsize}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 64,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_64.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,2.6/-1.8/C,4/0/D, 2/3/A}
\tkzDefMidPoint(A,B)\tkzGetPoint{E}
\tkzDefMidPoint(D,C)\tkzGetPoint{F}
\tkzCentroid(D,B,C)\tkzGetPoint{G}
\tkzInterLL(E,G)(C,D)\tkzGetPoint{I}
\tkzInterLL(A,F)(E,G)\tkzGetPoint{M}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C A,M M,I)
\tkzDrawSegments[dashed](B,D E,I B,F)
\tkzDrawPoints[fill=black](M,A,B,C,D,E,F,G)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,M)
\tkzLabelPoints[below left](G)
\tkzLabelPoints[left](B,E)
\tkzLabelPoints[right](D,F)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 65,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_65.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,3/-1.8/C,4/0/D, 1.5/3/A}
\tkzDefMidPoint(A,C)\tkzGetPoint{M}
\tkzDefMidPoint(B,C)\tkzGetPoint{N}
\tkzDefMidPoint(D,C)\tkzGetPoint{E}
\tkzInterLL(D,N)(B,E)\tkzGetPoint{P}
\tkzFillPolygon[pattern=north east lines,opacity=.3](M,N,D)
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C N,M D,M)
\tkzDrawSegments[dashed](B,D B,E N,D)
\tkzDrawPoints[fill=black](M,A,B,C,D,N,P)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,N,P)
\tkzLabelPoints[left](B,M)
\tkzLabelPoints[right](D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 66,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_66.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.8/-1.8/C,4/0/D, 2.2/3/A}
\tkzDefMidPoint(A,B)\tkzGetPoint{M}
\tkzDefMidPoint(B,C)\tkzGetPoint{N}
\tkzDefMidPoint(D,C)\tkzGetPoint{H}
\tkzInterLL(A,N)(C,M)\tkzGetPoint{G}
\tkzFillPolygon[pattern=north east lines,opacity=.3](M,C,D)
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C N,A C,M)
\tkzDrawSegments[dashed](B,D M,H M,D)
\tkzDrawPoints[fill=black](M,A,B,C,D,N,G,H)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,N,H)
\tkzLabelPoints[left](B,G)
\tkzLabelPoints[right](D)
\tkzLabelPoints[above left](M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 67,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_67.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.5/-1.5/D,4/0/C, 1.5/3/A}
\coordinate (E) at ($(A)!0.4!(B)$);
\coordinate (F) at ($(A)!0.65!(C)$);
\coordinate (G) at ($(B)!0.8!(D)$);
\tkzInterLL(E,G)(D,A)\tkzGetPoint{H}
\tkzInterLL(E,F)(B,C)\tkzGetPoint{I}
\tkzInterLL(G,I)(C,D)\tkzGetPoint{O}
\tkzDrawPolygon(A,B,D)
\tkzDrawSegments(E,H D,H H,F D,O O,I F,I A,F)
\tkzDrawSegments[dashed](B,I G,O O,C E,F F,C)
\tkzDrawPoints[fill=black](A,B,C,E,F,I,O,H,G)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above right](F,C,I)
\tkzLabelPoints[below](H)
\tkzLabelPoints[below right](O,D)
\tkzLabelPoints[left](B)
\tkzLabelPoints[above left](E)
\tkzLabelPoints[below left](G)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 68,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_68.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.5/-1.5/C,4/0/D, 1.5/3/A}
\tkzCentroid(D,B,C)\tkzGetPoint{G}
\coordinate (I) at ($(A)!0.6!(G)$);
\tkzDefMidPoint(D,C)\tkzGetPoint{M}
\tkzInterLL(B,I)(M,A)\tkzGetPoint{J}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C A,M)
\tkzDrawSegments[dashed](B,D B,M B,J A,G)
\tkzDrawPoints[fill=black](A,B,C,M,D,G,I,J)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above right](J)
\tkzLabelPoints[below](C,G)
\tkzLabelPoints[below right](M,I)
\tkzLabelPoints[left](B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 69,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_69.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.8/-1.8/C,4/0/D, 2.2/3/A}
\tkzDefMidPoint(A,B)\tkzGetPoint{H}
\tkzDefMidPoint(B,C)\tkzGetPoint{K}
\coordinate (M) at ($(C)!1.5!(D)$);
\tkzInterLL(K,M)(D,B)\tkzGetPoint{L}
\tkzInterLL(K,M)(D,A)\tkzGetPoint{N}
\tkzFillPolygon[pattern=north east lines,opacity=.3](K,H,L)
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C D,M M,N H,K)
\tkzDrawSegments[dashed](B,D N,K H,L)
\tkzDrawPoints[fill=black](M,A,B,C,D,H,K)
\tkzLabelPoints[above](A,M)
\tkzLabelPoints[below](C,D,L)
\tkzLabelPoints[left](B,H)
\tkzLabelPoints[below left](K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 70,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_70.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,3/-1.8/C,4/0/D, 1.5/3/A}
\tkzDefMidPoint(A,B)\tkzGetPoint{M}
\tkzDefMidPoint(D,C)\tkzGetPoint{N}
\coordinate (P) at ($(A)!0.7!(D)$);
\tkzInterLL(M,P)(B,D)\tkzGetPoint{I}
\tkzInterLL(B,C)(I,N)\tkzGetPoint{Q}
\tkzDrawPolygon(A,B,C)
\tkzDrawSegments(A,P C,N N,P N,I P,I M,Q)
\tkzDrawSegments[dashed](B,D M,P N,Q N,D P,D I,D M,N)
\tkzDrawPoints[fill=black](M,A,B,C,D,N,P,Q,I)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above right](P,D)
\tkzLabelPoints[below](C,Q)
\tkzLabelPoints[below right](N)
\tkzLabelPoints[left](B,M)
\tkzLabelPoints[right](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 71,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_71.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1.5/-1.5/B,4/0/C, 1.5/3/S}
\coordinate (L) at ($(S)!0.4!(A)$);
\coordinate (M) at ($(S)!0.75!(B)$);
\coordinate (N) at ($(A)!0.8!(C)$);
\tkzInterLL(M,L)(B,A)\tkzGetPoint{K}
\tkzInterLL(S,C)(L,N)\tkzGetPoint{J}
\tkzInterLL(B,C)(L,M)\tkzGetPoint{E}
\tkzInterLL(B,C)(K,N)\tkzGetPoint{I}
\tkzInterLL(B,C)(L,N)\tkzGetPoint{H}
\tkzDrawPolygon(S,A,B)
\tkzDrawSegments(L,K B,K K,I E,C S,J H,J)
\tkzDrawSegments[dashed](A,C B,E M,N L,N I,N N,H)
\tkzDrawPoints[fill=black](S,A,B,C,M,N,L,I,J,K)
\tkzLabelPoints[above](S,N)
\tkzLabelPoints[above right](C)
\tkzLabelPoints[below](K,B,J)
\tkzLabelPoints[below right](I)
\tkzLabelPoints[left](A,M,L)
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=72): PDF có nhưng không tạo được PNG

new TikzItem2
{
    Id = 73,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_73.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
\tkzDefPoints{0/0/B,0.5/-1.5/C,4/0/D, 1.5/3/A}
\tkzDefMidPoint(D,C)\tkzGetPoint{N}
\tkzCentroid(D,B,C)\tkzGetPoint{G}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C A,N)
\tkzDrawSegments[dashed](B,D A,G B,N)
\tkzDrawPoints[fill=black](G,A,B,C,D,N)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,G)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 74,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_74.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.5/-1.8/C,4/0/D, 2/3/A}
\coordinate (E) at ($(A)!0.4!(B)$);
\coordinate (F) at ($(A)!0.7!(C)$);
\tkzDrawPolygon(A,B,C)
\tkzDrawSegments(A,D E,F F,D C,D)
\tkzDrawSegments[dashed](B,D E,D)
\tkzDrawPoints[fill=black](E,A,B,C,D,F)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below left](C)
\tkzLabelPoints[left](B,E,F)
\tkzLabelPoints[right](D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 75,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_75.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.5/-1.8/C,4/0/D, 2/3/A}
\coordinate (E) at ($(A)!0.4!(B)$);
\coordinate (F) at ($(A)!0.7!(C)$);
\tkzInterLL(E,F)(C,B)\tkzGetPoint{I}
\tkzInterLL(E,F)(C,D)\tkzGetPoint{K}
\tkzDrawPolygon(A,B,C)
\tkzDrawSegments(A,D C,I E,I F,D K,D)
\tkzDrawSegments[dashed](B,D E,D C,K)
\tkzDrawPoints[fill=black](E,A,B,C,D,F)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](I)
\tkzLabelPoints[below left](C)
\tkzLabelPoints[left](B,E,F)
\tkzLabelPoints[right](D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 76,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_76.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=0.75cm,y=0.75cm]
\draw (0.0,-0.0)-- (2.0,-2.0);
\draw (5.0,0.0)-- (3.0,3.0);
\draw (3.0,3.0)-- (0.0,-0.0);
\draw (3.0,-3.0)-- (3.0,3.0)-- (4.0,-1.5);
\draw (3.0,3.0)-- (2.0,-2.0);
\draw (4.0,-1.5)-- (2.0,-2.0);
\draw (4.0,-1.5)-- (5.0,0.0);
\draw (2.0,-2.0)-- (3.0,-3.0)-- (4.0,-1.5);
\draw (1.5,1.5)-- (3.0,0.0)-- (4.0,1.5);
\draw [dash pattern=on 2pt off 2pt] (1.5,1.5)-- (4.0,1.5);
\draw [dash pattern=on 2pt off 2pt] (0.0,-0.0)-- (4.0,-1.5);
\draw [dash pattern=on 2pt off 2pt] (2.0,-2.0)-- (5.0,0.0);
\draw [dash pattern=on 2pt off 2pt] (0.0,-0.0)-- (5.0,0.0);
\begin{scriptsize}
\draw [fill=black] (0.0,-0.0) circle (1pt)[left] node {$A$};
\draw [fill=black] (2.0,-2.0) circle (1pt) [below left] node {$D$};
\draw [fill=black] (5.0,0.0) circle (1pt) [right] node {$B$};
\draw [fill=black] (4.0,-1.5) circle (1pt) [below right] node {$C$};
\draw [fill=black] (3.0,3.0) circle (1pt) [left] node {$S$};
\draw [fill=black] (3.0,-3.0) circle (1pt) [right] node {$E$};
\draw [fill=black] (1.5,1.5) circle (1pt) [left] node {$X$};
\draw [fill=black] (4.0,1.5) circle (1pt) [right] node {$Y$};
\draw [fill=black] (3.5,0.75) circle (1pt) [right] node {$Z$};
\draw [fill=black] (2.5,0.5) circle (1pt) [left] node {$T$};
\draw [fill=black] (3.0,0.0) circle (1pt) [below left] node {$Q$};
\end{scriptsize}
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=77): PDF có nhưng không tạo được PNG

new TikzItem2
{
    Id = 78,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_78.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.5/-1.8/C,4/0/D, 2/3/A}
\tkzDefMidPoint(A,C)\tkzGetPoint{M}
\tkzDefMidPoint(D,C)\tkzGetPoint{N}
\tkzCentroid(D,A,C)\tkzGetPoint{G}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C B,M D,M A,N)
\tkzDrawSegments[dashed](B,D B,G B,N)
\tkzDrawPoints[fill=black](M,A,B,C,D,N,G)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,N)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D)
\tkzLabelPoints[above right](M,G)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 79,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_79.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.5/-1.8/C,4/0/D, 2/2.5/A}
\tkzDefMidPoint(C,B)\tkzGetPoint{K}
\tkzDefMidPoint(A,D)\tkzGetPoint{I}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,K C,I)
\tkzDrawSegments[dashed](B,D B,I K,I K,D)
\tkzDrawPoints[fill=black](K,A,B,C,D,I)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above right](I)
\tkzLabelPoints[below](C)
\tkzLabelPoints[below left](K)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 80,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_80.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=0.75cm,y=0.75cm]
\draw (0.0,-0.0)-- (2.0,-2.0);
\draw (2.0,-2.0)-- (5.0,0.0);
\draw (5.0,0.0)-- (3.0,3.0);
\draw (3.0,3.0)-- (0.0,-0.0);
\draw (3.0,3.0)-- (2.0,-2.0);
%\draw [dash pattern=on 2pt off 2pt] (1.5,1.5)-- (3.5,-1.0);
\draw [dash pattern=on 2pt off 2pt] (0.0,-0.0)-- (5.0,0.0);
\begin{scriptsize}
\draw [fill=black] (0.0,-0.0) circle (1pt);
\draw[color=black] (-0.06,0.2) node {$B$};
\draw [fill=black] (2.0,-2.0) circle (1pt);
\draw[color=black] (1.7,-1.95) node {$C$};
\draw [fill=black] (5.0,0.0) circle (1pt);
\draw[color=black] (5.07,0.15) node {$D$};
\draw [fill=black] (3.0,3.0) circle (1pt);
\draw[color=black] (3.2,3.0) node {$A$};
\end{scriptsize}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 81,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_81.png",
    Code = @"\begin{tikzpicture}[line join=round,line cap=round,line width=.6pt,font=\footnotesize,scale=1]
\coordinate[label=left:$A$] (A) at (0,0);
\coordinate[label=below left:$B$] (B) at (1,-1);
\coordinate[label=right:$C$] (C) at (4,0);
\coordinate[label=above left:$D$] (D) at (1.2,3);
\coordinate[label=below:$M$] (M) at ($(B)!2/3!(C)$);
\coordinate[label=left:$E$] (E) at ($(A)!2/3!(D)$);
\coordinate[label=left:$G$] (G) at ($(B)!2/3!(E)$);
\draw (A)--(B)--(C)--(D)--cycle (D)--(B) (B)--(E);
\draw[dashed] (A)--(C) (M)--(G) (C)--(E);
\fill (A)circle(1.5pt) (B)circle(1.5pt) (C)circle(1.5pt) (D)circle(1.5pt) (G)circle(1.5pt) (M)circle(1.5pt) (E)circle(1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 82,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_82.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 5/0/C, 3/-1.5/B, 1/4/h};
\coordinate (S) at ($(A)+(h)$);
\tkzCentroid(S,A,B)\tkzGetPoint{M};
\tkzCentroid(S,B,C)\tkzGetPoint{N};
\coordinate (D) at ($(A)!0.5!(B)$);
\coordinate (E) at ($(B)!0.5!(C)$);
\tkzDrawPolygon(S,A,B);
\tkzDrawSegments(S,C B,C A,M S,D S,E);
\tkzDrawSegments[dashed](A,C A,N M,N D,E);
\tkzDrawPoints[fill=black](S,A,B,C,M,N,D,E);
\tkzLabelPoints[above](S);
\tkzLabelPoints[left](A,M);
\tkzLabelPoints[below](B,D,E);
\tkzLabelPoints[right](C,N);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 83,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_83.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 5/0/C, 2/-1.5/B, 1/4/h};
\coordinate (S) at ($(A)+(h)$);
\tkzCentroid(S,A,B)\tkzGetPoint{M};
\tkzCentroid(S,B,C)\tkzGetPoint{N};
\tkzCentroid(S,C,A)\tkzGetPoint{P};
\coordinate (Q) at ($(A)!3!(N)$);
\coordinate (D) at ($(A)!0.5!(B)$);
\coordinate (E) at ($(B)!0.5!(C)$);
\coordinate (F) at ($(C)!0.5!(A)$);
\tkzDrawPolygon(S,A,B);
\tkzDrawSegments(S,C B,C N,Q S,E S,D);
\tkzDrawSegments[dashed](A,C M,N N,P P,M A,N);
\tkzDrawPoints[fill=black](S,A,B,C,M,N,P,Q,D,E,F);
\tkzLabelPoints[above](S,P,Q,N);
\tkzLabelPoints[left](M,A);
\tkzLabelPoints[below](B,D,E,F);
\tkzLabelPoints[right](C);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 84,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_84.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.5/-1.8/D,4/0/C, 2/3/A}
\tkzDefMidPoint(B,C)\tkzGetPoint{N}
\tkzDefMidPoint(D,B)\tkzGetPoint{M}
\tkzCentroid(D,A,B)\tkzGetPoint{I}
\tkzCentroid(C,A,B)\tkzGetPoint{J}
\tkzDrawPolygon(A,B,D,C)
\tkzDrawSegments(A,D A,M)
\tkzDrawSegments[dashed](B,C M,N I,J A,N)
\tkzDrawPoints[fill=black](M,A,B,C,D,N,I,J)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](D)
\tkzLabelPoints[left](B,I)
\tkzLabelPoints[right](C)
\tkzLabelPoints[above right](J,N)
\tkzLabelPoints[below left](M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 85,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_85.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,0.5/-1.5/D,4/0/B,2.4/-1.5/C, 1.5/3/S}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{O}
\tkzInterLL(A,D)(B,C)\tkzGetPoint{I}
\tkzDrawPolygon(S,A,I,B)
\tkzDrawSegments(S,D S,C S,I)
\tkzDrawSegments[dashed](S,O A,B D,C A,C B,D)
\tkzDrawPoints[fill=black](S,A,B,C,D,O,I)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](O,I)
\tkzLabelPoints[left](A,D)
\tkzLabelPoints[right](C,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 86,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_86.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoints{0/0/B,1.5/-1.5/C, 4/0/D, 2/3/A}
\coordinate (M) at ($(A)!0.5!(D)$);
\coordinate (K) at ($(B)!0.5!(D)$);
\coordinate (I) at ($(A)!0.5!(C)$);
\coordinate (J) at ($(B)!0.5!(C)$);
\tkzDrawPoints(A,B,C,M,K,I,J)
\draw (A)--(B)--(C)--(D)--(A)--(C) (I)--(J);
\draw[dashed] (I)--(K)--(J) (M)--(K) (B)--(D);
\tkzLabelPoints[above](A)
\tkzLabelPoints[above right](D,M)
\tkzLabelPoints[below right](K,C)
\tkzLabelPoints[above left](I)
\tkzLabelPoints[below left](B,J)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 87,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_87.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
\tkzDefPoints{0/0/B,0.5/-1.5/C,4/0/D, 1.5/3/A}
\tkzDefMidPoint(D,C)\tkzGetPoint{N}
\tkzCentroid(D,B,C)\tkzGetPoint{G}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C A,N)
\tkzDrawSegments[dashed](B,D A,G B,N)
\tkzDrawPoints[fill=black](G,A,B,C,D,N)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,G)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 88,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_88.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/B, 4/-2/C, 6/0/D}
\coordinate (h) at ($(C)!.7!(D)$);
\coordinate (H) at ($(B)!.4!(h)$);
\coordinate (A) at ($(H)+(0,5)$);
\coordinate (M) at ($(A)!2/3!(B)$);
\coordinate (I) at ($(C)!.5!(D)$);
\tkzCentroid(D,B,C)\tkzGetPoint{G}
\tkzDefPointBy[symmetry=center I](G)\tkzGetPoint{H}
\tkzInterLL(A,I)(M,H)\tkzGetPoint{h}
\tkzInterLL(A,I)(M,G)\tkzGetPoint{K}
\tkzInterLL(A,I)(C,H)\tkzGetPoint{k}
\tkzInterLL(C,H)(M,G)\tkzGetPoint{i}
\tkzInterLL(M,H)(C,D)\tkzGetPoint{o}
\coordinate (E) at ($(A)!.5!(K)$);
\tkzDrawSegments[dashed](B,D M,I B,I I,H M,h G,D M,i h,k C,o G,E)
\tkzDrawSegments(A,B A,C A,D B,C o,D A,h M,C C,H h,H k,K i,K D,H)
\tkzLabelPoints[left](B,M)
\tkzLabelPoints[right](D,K,E)
\tkzLabelPoints[below](C,I,G,H)
\tkzLabelPoints[above](A)
\tkzDrawPoints[fill=black](A,B,C,D,M,I,G,H,K,E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 89,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_89.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/B, 7/0/D, 2/-3/C, 4/5/A}
\tkzDefPointBy[homothety = center B ratio 0.6](C) \tkzGetPoint{E}
\tkzDefPointBy[homothety = center B ratio 0.55](D) \tkzGetPoint{F}
\tkzDefPointBy[homothety = center A ratio 0.6](E) \tkzGetPoint{I}
\tkzDefPointBy[homothety = center A ratio 0.6](F) \tkzGetPoint{K}
\tkzDrawPoints(E,F,I,K)
\tkzDrawSegments(A,B B,C C,D D,A A,E A,C)
\tkzDrawSegments[dashed](B,D A,F E,F I,K)
\tkzLabelPoints[below left](E)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B,I)
\tkzLabelPoints[right](K,D)
\tkzLabelPoints[below](C,F)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 90,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_90.png",
    Code = @"\begin{tikzpicture}[scale=0.75, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{4/9/A, 0/3/B, 5/1/C, 7/3/D}
\tkzDefMidPoint(B,C)\tkzGetPoint{M}
\tkzDefMidPoint(D,C)\tkzGetPoint{N}
\tkzDefMidPoint(D,B)\tkzGetPoint{L}
\tkzCentroid(A,B,C)\tkzGetPoint{G1}
\tkzCentroid(A,D,C)\tkzGetPoint{G2}
\tkzCentroid(A,B,D)\tkzGetPoint{G3}
\tkzDefLine[parallel=through G1](C,B) \tkzGetPoint{X}
\tkzInterLL(G1,X)(A,B)\tkzGetPoint{E}
\tkzInterLL(G1,X)(C,A)\tkzGetPoint{F}
\tkzInterLL(G2,F)(D,A)\tkzGetPoint{G}
\tkzDrawSegments(A,B B,C C,D D,A A,C E,F F,G A,M A,N)
\tkzDrawSegments[dashed](B,D L,M M,N N,L A,L E,G)
\tkzLabelPoints[right](G,D,N,F)
\tkzLabelPoints[left](E,B)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,L,M)
\node[below left] at (G1) {$ G_1 $};
\node[above left] at (G2) {$ G_2 $};
\node[above right] at (G3) {$ G_3 $};
\tkzDrawPoints[fill=black](A,B,C,D,M,N,L,E,F,G,G1,G2,G3)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 91,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_91.png",
    Code = @"\begin{tikzpicture}[>=stealth=0.5, line join=round, line cap = round,scale=0.7]
\tkzDefPoints{0/0/A,1.5/-2/B,8/0/C,1.5/6/S}
\tkzDefMidPoint(B,C)\tkzGetPoint{E}
\tkzDefPointBy[homothety=center A ratio 2/3](E)\tkzGetPoint{G}
\tkzDefPointBy[homothety=center A ratio 2/3](S)\tkzGetPoint{M}
\tkzDefPointBy[homothety=center A ratio 1/3](S)\tkzGetPoint{N}
\tkzDefPointBy[homothety=center A ratio 2](G)\tkzGetPoint{D}
\tkzInterLL(D,M)(S,E)\tkzGetPoint{H}
\tkzInterLL(D,H)(C,E)\tkzGetPoint{X}
\tkzDrawSegments(A,B B,E S,A S,B S,C S,E D,E C,D B,N D,H)
\tkzDrawSegments[dashed](A,C A,E G,M M,C B,G G,N H,M E,X E,C)
%Gán nhãn
\tkzDrawPoints[fill=black](A,B,C,S,E,G,M,N,H,D)
\tkzLabelPoints[left](A,M,N)
\tkzLabelPoints[below](B,G,E)
\tkzLabelPoints[right](C,D,H)
\tkzLabelPoints[above](S)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 92,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_92.png",
    Code = @"\begin{tikzpicture}[line join=round, line cap=round,>=stealth,scale=1,font=\footnotesize]
\tkzInit[ymin=-2.5,ymax=5,xmin=-2.5,xmax=5.5]
\tkzClip
\tkzDefPoints{0/0/B,5/0/D,2/-2/C,1/4/A}
\tkzDefMidPoint(B,A)\tkzGetPoint{I}
\tkzDefMidPoint(C,D)\tkzGetPoint{J};
\coordinate (M) at ($(I)!0.6!(J)$);
\tkzDefLine[parallel=through M](C,D) \tkzGetPoint{m}
\tkzInterLL(M,m)(I,D) \tkzGetPoint{F}
\tkzInterLL(M,m)(I,C) \tkzGetPoint{E}
\tkzDefLine[parallel=through F](A,B) \tkzGetPoint{f}
\tkzInterLL(F,f)(B,D) \tkzGetPoint{G}
\tkzInterLL(F,f)(A,D) \tkzGetPoint{P}
\tkzDefLine[parallel=through E](A,B) \tkzGetPoint{e}
\tkzInterLL(E,e)(B,C) \tkzGetPoint{H}
\tkzInterLL(E,e)(A,C) \tkzGetPoint{Q}
\tkzDrawPoints[fill=black](A,B,M,C,D,I,J,E,F,G,H,P,Q)
\tkzLabelPoints(C,J)
\tkzLabelPoints[above](A,M)
\tkzLabelPoints[above left](I)
\tkzLabelPoints[above right](F)
\tkzLabelPoints[below left](H)
\tkzLabelPoints[below right](G)
%\tkzLabelPoints[above right](M)
\tkzLabelPoints[right](D,P)
\tkzLabelPoints[left](B,E,Q)
\tkzDrawSegments(A,B B,C C,A A,D C,D I,C Q,H P,Q)
\tkzDrawSegments[dashed](B,D I,J I,D E,F G,H P,G)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 93,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_93.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoints{0/0/B, 7/0/D, 2/-3/C, 4/5/A}
\tkzDefMidPoint(A,D) \tkzGetPoint{N} 
\coordinate (M) at ($(B)!.666666!(C)$);
\tkzCentroid(A,B,D) \tkzGetPoint{G}
\tkzDrawPoints(M,N,G)
\tkzDrawSegments(A,B B,C C,D D,A C,N A,C)
\tkzDrawSegments[dashed](B,D M,G B,N)
\tkzLabelPoints[below left](M)
\tkzLabelPoints[above](A,G)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](N,D)
\tkzLabelPoints[below](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 94,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_94.png",
    Code = @"\begin{tikzpicture}[scale=1,fill=black]
\coordinate (A) at (-1,0);
\coordinate (B) at (0,-2);
\coordinate (C) at (4,0);
\coordinate (S) at (1,4);
\coordinate (M) at ($(B)!0.5!(C)$);
\coordinate (I) at ($(C)!0.5!(A)$);
\coordinate (N) at ($(S)!0.5!(B)$);
\coordinate (H) at ($(I)!0.5!(C)$);
\coordinate (Q) at ($(S)!0.5!(A)$);
\coordinate (K) at ($(S)!0.5!(Q)$);
\tkzLabelPoints[right](C)
\tkzLabelPoints[below](B, M)
\tkzLabelPoints[above=0.1](I,S,H)
\tkzLabelPoints[left](A,K,N)
\tkzDrawSegments(S,A S,B S,C M,N K,N A,B B,C)
\tkzDrawSegments[dashed](A,C M,H H,K B,I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 95,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_95.png",
    Code = @"\begin{tikzpicture}[scale=0.6,fill=black]
\coordinate (A) at (-1,0);
\coordinate (B) at (0,-2);
\coordinate (C) at (4,0);
\coordinate (S) at (1,3);
\coordinate (M) at ($(B)!0.5!(C)$);
\coordinate (I) at ($(C)!0.5!(A)$);
\tkzLabelPoints[right,font=\footnotesize](C)
\tkzLabelPoints[below,font=\footnotesize](B,M)
\tkzLabelPoints[above=0.1,font=\footnotesize](S,I)
\tkzLabelPoints[left,font=\footnotesize](A)
\tkzDrawSegments(S,A S,B S,C A,B B,C)
\tkzDrawSegments[dashed](A,C B,I)
\tkzDrawPoints[size=5,fill=black](A,B,C,S,I,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 96,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_96.png",
    Code = @"\begin{tikzpicture}[line join=round, line cap=round,>=stealth,scale=0.8]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A, 3/-2/D, 6/0/B}
\coordinate (Y) at ($(A)!0.5!(B)$);
\coordinate (C) at ($(Y)+(0,4)$);
\coordinate (I) at ($(A)!0.5!(C)$);
\coordinate (J) at ($(B)!0.5!(C)$);
\coordinate (K) at ($(B)!0.66!(D)$);
\coordinate (P) at ($(I)!0.8!(J)$);
\tkzDefLine[parallel = through K](A,B) \tkzGetPoint{x}
\tkzDrawLines[add = 0.01 and -0.6,dashed](K,x)
\tkzInterLL(A,D)(K,x)\tkzGetPoint{H}
\tkzDrawSegments[dashed](A,D A,B H,K I,J K,P)
\tkzDrawSegments(I,H J,K)
\tkzDrawPoints(A,B,C,D,K,H,I,J,P)
\tkzDrawPolygon(A,C,D)
\tkzDrawPolygon(B,C,D)
\tkzLabelPoints[left](A,I)
\tkzLabelPoints[right](B,J)
\tkzLabelPoints[above](C,P)
\tkzLabelPoints[below](D,H,K)
\tkzMarkRightAngle(K,P,I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 97,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_97.png",
    Code = @"\begin{tikzpicture}[scale=1, fill=black]
\coordinate (A) at (1,4);
\coordinate (B) at (-1,0);
\coordinate (D) at (4,-1);
\coordinate (C) at (1,-2);
\coordinate (P) at ($(B)!0.5!(C)$);
\coordinate (Q) at ($(D)!0.5!(C)$);
\coordinate (M) at ($(A)!0.666!(Q)$);
\coordinate (N) at ($(B)!0.666!(Q)$);
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B,P)
\tkzLabelPoints[below=0.1](N)
\tkzLabelPoints[right](D,M)
\tkzLabelPoints[below](C,Q)
\tkzDrawSegments(A,B A,C A,D B,C C,D A,Q)
\tkzDrawSegments[dashed](B,D B,Q M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 98,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_98.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\coordinate (B) at (-1,0);
\coordinate (D) at (4,0);
\coordinate (C) at (0,-2);
\coordinate (A) at (1,3);
\coordinate (H) at ($(B)!0.5!(C)$);
\coordinate (G) at ($(A)!0.666!(H)$);
\coordinate (M) at ($(D)!0.333!(C)$);
\tkzLabelPoints[above,font=\footnotesize](A)
\tkzLabelPoints[right,font=\footnotesize](D)
\tkzLabelPoints[left,font=\footnotesize](B,G)
\tkzLabelPoints[below,font=\footnotesize](C,M)
\tkzDrawSegments(A,B A,C C,D D,A A,H A,M B,C)
\tkzDrawSegments[dashed](B,D G,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 99,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_99.png",
    Code = @"\begin{tikzpicture}
\coordinate (B) at (-1,0);
\coordinate (D) at (4,0);
\coordinate (C) at (0,-2);
\coordinate (A) at (1,4);
\coordinate (N) at ($(A)!0.5!(B)$);
\coordinate (H) at ($(B)!0.5!(C)$);
\coordinate (G) at ($(A)!0.666!(H)$);
\coordinate (M) at ($(D)!0.333!(C)$);
\tkzDefPointBy[translation= from G to M](B)
\tkzGetPoint{x}
\tkzDefPointBy[translation= from G to M](A)
\tkzGetPoint{y}
\tkzLabelPoints[above](A,y)
\tkzLabelPoints[right](D,M,x)
\tkzLabelPoints[left](B,N,G)
\tkzLabelPoints[below](C)
\tkzDrawSegments(A,B A,C C,D D,A A,H C,N A,M B,C A,y)
\tkzDrawSegments[dashed](B,D G,M B,M N,D B,x)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 100,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_100.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,>=stealth,font=\footnotesize,scale=1]
\tkzDefPoints{0/0/A}
\coordinate (C) at ($(A)+(5,0)$);
\tkzDefShiftPoint[A](-30:3){B}
\coordinate (S) at ($(A)+(1.5,4)$);
\coordinate (E) at ($(S)!0.5!(B)$);
\coordinate (F) at ($(A)!0.5!(B)$);
\coordinate (G) at ($(A)!0.13!(C)$);
\coordinate (H) at ($(S)!0.13!(C)$);
\coordinate (x) at ($(S)+(C)-(A)$);
\coordinate (D) at ($(A)+(C)-(S)$);
\coordinate (K) at ($(D)!0.8!(C)$);
\tkzDrawPolygon(S,A,B,C)
\tkzDrawSegments(S,B K,x E,F E,C)
\tkzDrawSegments[dashed](A,C G,H F,C G,E F,G)
\tkzMarkSegments[mark=||,pos=.5,size=2pt](E,S E,B)
\tkzMarkSegments[mark=|,pos=.5,size=2pt](F,A F,B)
\tkzDrawPoints[fill=black](B,C,A,S,E,F,G,H)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](C,x)
\tkzLabelPoints[above right](H,E)
\tkzLabelPoints[below left](F)
\tkzLabelPoints[above left](G)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 101,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_101.png",
    Code = @"\begin{tikzpicture}%[scale=1]
%\tkzInit[xmin=-5,ymin=-1.5,xmax=3,ymax=2]
%\tkzClip
\tkzDefPoints{-3/0/B,2/0/D,-1/3/A} % Định nghĩa các toạ đô dịnh cơ sở
\tkzDefPointsBy[homothety=center B ratio 0.6](D){B1}
\tkzDefPointBy[rotation = center B angle -30](B1)
\tkzGetPoint{C}
\tkzDefMidPoint(A,B)
\tkzGetPoint{M}
\tkzDefMidPoint(C,B)
\tkzGetPoint{N}
\tkzDefPointsBy[homothety=center A ratio 0.3](D){Q}
\tkzInterLL(M,Q)(B,D)
\tkzGetPoint{K}
\tkzInterLL(K,N)(C,D)
\tkzGetPoint{P}
\tkzLabelPoints[above](A)
\tkzLabelPoints[above right](Q)
\tkzLabelPoints[above left](K,B,M)
\tkzLabelPoints[right](D,P)
\tkzLabelPoints[below](C,N)
\tkzDrawSegments[dashed](B,D M,Q M,B B,N B,K N,P)
\tkzDrawSegments(A,M A,C A,D A,M Q,P C,D N,C M,K N,K M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 102,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_102.png",
    Code = @"\begin{tikzpicture}[line join=round, line cap=round,>=stealth,scale=0.8]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B, 2/-1/C, 4/0/D}
\coordinate (Y) at ($(B)!0.3!(D)$);
\coordinate (A) at ($(Y)+(0,3)$);
\coordinate (I) at ($(B)!0.5!(C)$);
\coordinate (J) at ($(B)!0.5!(D)$);
\coordinate (E) at ($(A)!0.4!(D)$);
\tkzDefLine[parallel = through E](C,D) \tkzGetPoint{x}
\tkzInterLL(A,C)(E,x)\tkzGetPoint{F}
\tkzDrawSegments[dashed](B,D I,J E,J)
\tkzDrawSegments(E,F F,I)
\tkzDrawPoints(A,B,C,D,I,J,E,F)
\tkzDrawPolygon(A,B,C)
\tkzDrawPolygon(A,C,D)
\tkzLabelPoints[left](B,F)
\tkzLabelPoints[right](D,E)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,I,J)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 103,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_103.png",
    Code = @"\begin{tikzpicture}[scale=0.8,font=\footnotesize,line join=round,line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 1/-2.5/B, 3/-2.5/C, 7/0/D, 1.5/5/S}
\coordinate (M) at ($(S)!1/4!(D)$);
\tkzInterLL(A,B)(C,D) \tkzGetPoint{K}
\tkzDefPointBy[translation=from A to D](S) \tkzGetPoint{d}
\tkzInterLL(K,M)(S,C) \tkzGetPoint{N}
\coordinate (x) at ($(d)!5/4!(S)$);
\tkzInterLL(A,M)(d,x) \tkzGetPoint{E}
\tkzDrawPolygon(S,A,K,D)
\tkzDrawSegments(S,B S,C B,K C,K x,d K,M M,E N,E)
\tkzDrawSegments[dashed](A,D A,M B,C B,N)
\tkzDrawPoints[fill=black](S,A,B,C,D,M,K,N,E)
\tkzLabelPoints[above](S,d,E,M)
\tkzLabelPoints[right](D,N)
\tkzLabelPoints[left](A)
\tkzLabelPoints[below](K)
\tkzLabelPoints[below right](C)
\tkzLabelPoints[below left](B)
%\tkzLabelPoints[above right]()
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 104,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_104.png",
    Code = @"\begin{tikzpicture}
\tkzInit[xmin=-0.5,ymin=-2,xmax=7,ymax=5.5]
\tkzClip
\tkzDefPoint(0,1){B}
\tkzDefShiftPoint[B](0:5){C}
\tkzDefShiftPoint[B](90:4){S}
\tkzDefShiftPoint[B](-70:2){A}
\tkzDefMidPoint(B,C) \tkzGetPoint{I}
\tkzDefPointBy[homothety=center A ratio 0.54](B) \tkzGetPoint{M}
\tkzDefLine[parallel=through M](A,I) \tkzGetPoint{d}
\tkzInterLL(B,C)(M,d)\tkzGetPoint{N}
\tkzDefLine[parallel=through M](S,B) \tkzGetPoint{d1}
\tkzInterLL(S,A)(M,d1)\tkzGetPoint{Q}
\tkzDefLine[parallel =through N](S,B) \tkzGetPoint{d2}
\tkzInterLL(S,C)(N,d2)\tkzGetPoint{P}
\tkzMarkRightAngle(C,A,B)
\tkzMarkRightAngle(C,B,S)
\tkzFillPolygon[color=gray!20](M,N,P,Q)
\tkzDrawSegments(S,A S,C A,B A,C S,B P,Q Q,M)
\tkzDrawSegments[dashed](B,C A,I M,N N,P)
\tkzDrawPoints[fill=white,color=black,size=8pt](S,A,B,C,I,M,N,P,Q)
\node at ($(A)+(190:3mm)$){\footnotesize $A$};
\node at ($(B)+(200:3mm)$){\footnotesize $B$};
\node at ($(C)+(-50:3mm)$){\footnotesize $C$};
\node at ($(I)+(80:3mm)$){\footnotesize $I$};
\node at ($(S)+(170:3mm)$){\footnotesize $S$};
\node at ($(M)+(170:3mm)$){\footnotesize $M$};
\node at ($(N)+(10:3mm)$){\footnotesize $N$};
\node at ($(P)+(40:3mm)$){\footnotesize $P$};
\node at ($(Q)+(180:3mm)$){\footnotesize $Q$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 105,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_105.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=1]
\coordinate (A) at (4,4);
\coordinate (B) at (0,0);
\coordinate (C) at (6,0);
\coordinate (D) at (5,-2);
\coordinate (M) at ($(A)!.5!(D)$);
\coordinate (N) at ($(B)!.5!(D)$);
\coordinate (X) at ($(A)!.5!(B)$);
\coordinate (G) at ($(C)!2/3!(X)$);
\coordinate (P) at ($(C)!2/3!(A)$);
\coordinate (Q) at ($(C)!2/3!(B)$);
\draw (A)--(B)--(D)--(C)--(A)--(D) (M)--(N);
\draw[dashed] (M)--(G)--(N) (P)--(Q) (C)--(X) (B)--(C);
\foreach \p/\pos in {A/above, B/left, D/below, C/right, M/right, N/below, P/right, G/above, Q/above}
\fill (\p) circle(1pt) node[\pos]{\p};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 106,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_106.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=1]
\coordinate (A) at (2,4.5);
\coordinate (B) at (0,0);
\coordinate (C) at (6,0);
\coordinate (D) at (3,-2);
\coordinate (M) at ($(A)!.7!(B)$);
\coordinate (N) at ($(A)!.7!(C)$);
\coordinate (X) at ($(C)+(D)-(B)$);
\coordinate (Y) at ($(D)!.5!(X)$);
\coordinate (Z) at ($(D)!-0.3!(X)$);
\draw (A)--(B)--(D)--(C)--(A)--(D)--(M) (D)--(N) (Y)--(Z);
\draw[dashed] (M)--(N) (B)--(C);
\foreach \p/\pos in {A/above,B/left,C/right,D/below,M/above left, N/above right}
\fill (\p) circle(1pt)node[\pos]{\p};
\draw (Y) node[above] {$x$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 107,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_107.png",
    Code = @"\begin{tikzpicture}[scale=0.6,font=\footnotesize,line join=round,line cap=round,>=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B, 3/6/A, 1.3/-3/C, 8/0/D}
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(C)!0.5!(D)$);
\coordinate (P) at ($(B)!0.5!(C)$);
\coordinate (Q) at ($(A)!0.5!(D)$);
\coordinate (R) at ($(A)!0.5!(C)$);
\coordinate (S) at ($(B)!0.5!(D)$);
\coordinate (G) at ($(M)!0.5!(N)$);
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C M,P Q,N P,R R,Q)
\tkzDrawSegments[dashed](B,D R,S M,N P,Q M,Q P,N P,S S,Q)
\tkzDrawPoints[fill=black](A,B,C,D,M,N,P,Q,R,S,G)
\tkzLabelPoints[above](A,G)
\tkzLabelPoints[right](D)
\tkzLabelPoints[left](B,R)
\tkzLabelPoints[below](C)
\tkzLabelPoints[below right](S,N)
\tkzLabelPoints[below left](P)
\tkzLabelPoints[above right](Q)
\tkzLabelPoints[above left](M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 108,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_108.png",
    Code = @"\begin{tikzpicture}[scale=0.6, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1.3/-1.6/C,4.5/0/D,1/3.5/A}
\coordinate (M) at ($1/2*(A)+1/2*(B)$);
\coordinate (N) at ($1/3*(B)+2/3*(C)$);
\coordinate (K) at ($1/3*(A)+1/3*(C)+1/3*(D)$);
\coordinate (G) at ($1/2*(C)+1/2*(D)$);
\tkzInterLL(M,K)(B,G)\tkzGetPoint{H}
\tkzInterLL(M,N)(A,C)\tkzGetPoint{E}
\tkzInterLL(E,K)(C,D)\tkzGetPoint{P}
\tkzInterLL(E,K)(A,D)\tkzGetPoint{Q}
\tkzInterLL(M,Q)(N,P)\tkzGetPoint{F}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C A,G H,K H,G E,M E,A E,Q F,N F,M)
\tkzDrawSegments[dashed](B,D M,K B,G N,P M,Q F,B)
\tkzDrawPoints[fill=black,size=4](A,B,C,D,K,G,H,E)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](F, E)
\tkzLabelPoints[above left](B,M)
\tkzLabelPoints[below left](N)
\tkzLabelPoints[below right](C,P,G)
\tkzLabelPoints[right](D,K,Q,H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 109,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_109.png",
    Code = @"\begin{tikzpicture}[scale=0.9,font=
\footnotesize,line join=round,line cap=round, >=stealth]
\tkzDefPoints{0/0/A,3/-2/B,6/0/C,0/5/S}
\tkzDefMidPoint(S,A)\tkzGetPoint{K}
\tkzDefMidPoint(B,C)\tkzGetPoint{N}
\tkzDefPointBy[homothety=center S ratio 0.4](C)\tkzGetPoint{M}
\tkzDefPointBy[homothety=center S ratio 0.8](C)\tkzGetPoint{E}
\tkzInterLL(A,C)(K,M)\tkzGetPoint{I}
\tkzInterLL(A,B)(I,N)\tkzGetPoint{L}
\tkzDrawSegments(S,B S,C B,C K,I I,L K,L S,K M,N L,B)
\tkzDrawSegments[dashed](A,C A,I L,N K,M K,N A,L A,K A,E)
\tkzDrawPoints(A,B,C,S,K,M,N,L,I,E)
\tkzLabelPoints[above left](K)
\tkzLabelPoints[below left](A,L)
\tkzLabelPoints[above](I)
\tkzLabelPoints[left](S)
\tkzLabelPoints[above right](M,E)
\tkzLabelPoints[below right](C,N,B)
\tkzMarkSegments[mark=||](K,A K,S)
\tkzMarkSegments[mark=|](M,E M,S)
\tkzMarkSegments[mark=|||](N,B N,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 110,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_110.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 7/0/B,2/-2.1/D, 4.8/-1.6/C, 2/4/S}
\coordinate (I) at ($(A)!0.3!(D)$);
\coordinate (J) at ($(S)!0.33!(B)$);
\tkzDrawPoints[fill=black](S,A,B,C,D,I,J)
\tkzLabelPoints[above](S)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](B)
\tkzLabelPoints[below right](C)
\tkzLabelPoints[below left](D)
\tkzLabelPoints[below left](I)
\tkzLabelPoints[above right](J)
\tkzDrawSegments(S,A S,B S,C S,D A,D B,C S,I)
\tkzDrawSegments[dashed](A,C A,B B,D C,D I,J D,J I,B) 
\tkzInterLL(A,D)(B,C)\tkzGetPoint{O}
\tkzInterLL(S,C)(O,J)\tkzGetPoint{M}
\tkzInterLL (A,C)(B,I)\tkzGetPoint{E}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{F}
\tkzInterLL(A,M)(I,J)\tkzGetPoint{K}
\tkzInterLL(D,J)(S,F)\tkzGetPoint{L}
\tkzDrawPoints[fill=black](O,E,M,F,K,L)
\tkzDrawSegments[dashed](S,E A,M)
\tkzLabelPoints[below](O)
\tkzLabelPoints[right](M)
\tkzLabelPoints[below](E)
\tkzLabelPoints[below](F)
\tkzLabelPoints[above left](L)
\tkzDrawSegments(O,D O,C O,J)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 111,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_111.png",
    Code = @"\begin{tikzpicture}[scale=0.6,font=\footnotesize,line join=round,line cap=round,>=stealth]
\tkzDefPoints{0/0/B, 3/4/A, 5/-3/C, 6/0/D}
\coordinate (E) at ($(A)!0.5!(B)$);
\coordinate (I) at ($(E)!1/3!(C)$);
\coordinate (J) at ($(E)!1/3!(D)$);
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C E,C)
\tkzDrawSegments[dashed](E,D I,J B,D)
\tkzDrawPoints[fill=black](A,B,C,D,E,I,J)
\tkzLabelPoints[above](A,J)
\tkzLabelPoints[right](D,I)
\tkzLabelPoints[left](B,E)
\tkzLabelPoints[below](C)
\tkzMarkSegments[mark=||](E,A E,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 112,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_112.png",
    Code = @"\begin{tikzpicture}[scale=1,font=
\footnotesize,line join=round,line cap=round, >=stealth]
\tkzDefPoints{0/0/A,7/0/B,2/4/S,2/-3/H}
\tkzDefPointBy[homothety=center A ratio 0.6](H)\tkzGetPoint{D}
\tkzDefPointBy[homothety=center B ratio 0.6](H)\tkzGetPoint{C}
\tkzDefPointBy[homothety=center S ratio 0.4](B)\tkzGetPoint{M}
\tkzInterLL(A,C)(B,D) \tkzGetPoint{O}
\tkzInterLL(S,O)(D,M) \tkzGetPoint{I}
\tkzInterLL(S,A)(C,I) \tkzGetPoint{J}
\tkzDrawSegments[dashed](A,B A,C B,D S,O D,C D,M C,J)
\tkzDrawSegments(S,A S,B S,D S,H S,C A,H B,H C,M)
\tkzDrawPoints(A,B,C,S,O,H,D,M,I,J)
\tkzLabelPoints[left](A,H,D,S,J)
\tkzLabelPoints[below right](B,C)
\tkzLabelPoints[right](M,I)
\tkzLabelPoints[below](O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 113,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_113.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/B,1.3/-1.6/C,4.5/0/D,1/3.5/A,2/-0.5/O}
\coordinate (M) at ($(A)!2/3!(B)$);
\coordinate (N) at ($(A)!0.4!(C)$);
\tkzInterLL(M,N)(B,C)\tkzGetPoint{H}
\tkzInterLL(B,D)(H,O)\tkzGetPoint{I}
\tkzInterLL(C,D)(H,O)\tkzGetPoint{J}
\tkzDrawSegments(C,D A,B A,D A,C H,N H,C N,J)
\tkzDrawSegments[dashed](B,D H,J N,O M,I M,O)
\tkzDrawPoints[fill=black](A,B,C,D,M,N,H,O,I,J)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,O,I,J)
\tkzLabelPoints[left](B,M,H)
\tkzLabelPoints[right](D,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 114,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_114.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize,line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/B,2/-2/C,6/0/D,2/4/A}
\tkzDefMidPoint(A,B)\tkzGetPoint{M}
\tkzDefMidPoint(B,C)\tkzGetPoint{N}
\tkzDefMidPoint(C,D)\tkzGetPoint{P}
\tkzInterLL(B,P)(D,N)\tkzGetPoint{G}
\tkzInterLL(A,G)(M,P)\tkzGetPoint{I}
\tkzInterLL(C,M)(A,N)\tkzGetPoint{J}
\tkzDrawSegments(A,B B,C C,D D,A A,C A,N C,M A,P)
\tkzDrawSegments[dashed](B,D B,P D,N M,P D,J A,G D,M)
\tkzDrawPoints[fill=black](A,B,C,D,M,N,P,I,J,G)
\tkzLabelPoints[left](M,J)
\tkzLabelPoints[above right](I)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](D,C,B,N,P,G)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 115,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_115.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,1.5/-2/B,5/0/C,3/-0.5/K}
\coordinate (S) at ($(A)+(1,4)$);
\coordinate (M) at ($(A)!0.4!(B)$);
\coordinate (I) at ($(S)!0.5!(M)$);
\coordinate (N) at ($(B)!0.4!(C)$);
\coordinate (J) at ($(S)!0.6!(N)$);
\tkzInterLL(I,J)(M,N)\tkzGetPoint{H}
\tkzInterLL(K,H)(B,C)\tkzGetPoint{D}
\tkzInterLL(K,H)(A,C)\tkzGetPoint{E}
\tkzInterLL(D,J)(S,B)\tkzGetPoint{F}
\tkzInterLL(F,I)(S,A)\tkzGetPoint{L}
\tkzInterLL(B,C)(J,H)\tkzGetPoint{T}
\tkzDrawSegments(S,A S,C B,N A,B S,B S,M S,N J,H N,H F,J L,F T,C)
\tkzDrawSegments[dashed](A,C M,N I,J E,H L,E J,K J,D N,T)
\tkzDrawPoints[fill=black](A,B,C,S,M,N,I,J,H,K,D,E,F,L)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B,M,N,H,D,K,E)
\tkzLabelPoints[left](A,I,L)
\tkzLabelPoints[right](C,J,F)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 116,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_116.png",
    Code = @"\begin{tikzpicture}[line cap=round, line join=round,font=\footnotesize,>=stealth, scale=1]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B, 4/0/D, 1.6/-1.2/C, 1/3/A}
\tkzDefBarycentricPoint(A=0.35,D=0.65)\tkzGetPoint{N}
\tkzDefBarycentricPoint(A=0.6,C=0.4)\tkzGetPoint{M}
\tkzDefBarycentricPoint(B=0.35,C=0.3,D=0.35)\tkzGetPoint{O}
\tkzInterLL(M,N)(C,D)\tkzGetPoint{I}
\tkzInterLL(B,C)(O,I)\tkzGetPoint{P}
\tkzInterLL(D,B)(O,I)\tkzGetPoint{Q}
\tkzDrawSegments[dashed](B,D I,O O,M O,N O,P)
\tkzDrawSegments(A,B B,C C,D A,C M,I A,D I,D P,M)
\tkzLabelPoints[above](A,Q)
\tkzLabelPoints[left](B,M)
\tkzLabelPoints[below](C,O)
\tkzLabelPoints[below right](D)
\tkzLabelPoints[above right](N,I)
\tkzLabelPoints[below left](P)
\tkzDrawPoints[fill=black](A,B,C,D,M,N,P,Q,I,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 117,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_117.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize,line join=round, line cap=round,>=stealth]
\tkzDefPoints{-2/0/A,0/-2.5/B,3/0/C,1/4/S}
\coordinate (I) at ($(A)!0.5!(S)$);
\coordinate (H) at ($(A)!0.5!(B)$);
\coordinate (M) at ($(I)!0.5!(H)$);
\coordinate (K) at ($(S)!1/4!(C)$);
\coordinate (D) at ($(S)!0.5!(C)$);
\coordinate (N) at ($(B)!0.5!(C)$);
\tkzInterLL(A,C)(K,I)\tkzGetPoint{E}
\tkzInterLL(E,H)(B,C)\tkzGetPoint{F}
\tkzInterLL(K,M)(E,H)\tkzGetPoint{J}
\tkzDrawSegments(H,B B,C S,I S,B S,C E,I K,F E,H I,H M,J)
\tkzDrawSegments[dashed](A,H A,C A,N H,F H,K A,D M,K E,A A,I I,K)
\tkzDrawPoints[fill=black](A,B,C,S,I,H,M,K,E,F,D,J,N)
\tkzLabelPoints[left](A,B,E)
\tkzLabelPoints[right](C,M,K,F,D,N)
\tkzLabelPoints[above](S)
\tkzLabelPoints[above left](I)
\tkzLabelPoints[below](H,J)
\tkzMarkSegments[mark=|](S,K K,D)
\tkzMarkSegments[mark=||](A,H H,B)
\tkzMarkSegments[mark=|||](A,I S,I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 118,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_118.png",
    Code = @"\begin{tikzpicture}[line cap=round, line join=round,font=\footnotesize,>=stealth, scale=1]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B, 4/0/D, 1.6/-1.2/C, 1/3/A}
\tkzDefBarycentricPoint(A=0.35,D=0.65)\tkzGetPoint{N}
\tkzDefBarycentricPoint(A=0.6,C=0.4)\tkzGetPoint{M}
\tkzDefBarycentricPoint(B=0.35,C=0.3,D=0.35)\tkzGetPoint{O}
\tkzInterLL(M,N)(C,D)\tkzGetPoint{I}
\tkzInterLL(B,C)(O,I)\tkzGetPoint{P}
\tkzInterLL(D,B)(O,I)\tkzGetPoint{Q}
\tkzDrawSegments[dashed](B,D I,O O,M O,N O,P N,Q)
\tkzDrawSegments(A,B B,C C,D A,C M,I A,D I,D P,M)
\tkzLabelPoints[above](A,Q)
\tkzLabelPoints[left](B,M)
\tkzLabelPoints[below](C,O)
\tkzLabelPoints[below right](D)
\tkzLabelPoints[above right](N,I)
\tkzLabelPoints[below left](P)
\tkzDrawPoints[fill=black](A,B,C,D,M,N,P,Q,I,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 119,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_119.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,1.5/-2/B,5/0/C,3/-0.5/K}
\coordinate (S) at ($(A)+(1,4)$);
\coordinate (M) at ($(A)!0.4!(B)$);
\coordinate (I) at ($(S)!0.5!(M)$);
\coordinate (N) at ($(B)!0.4!(C)$);
\coordinate (J) at ($(S)!0.6!(N)$);
\tkzInterLL(I,J)(M,N)\tkzGetPoint{H}
\tkzDrawPolygon(S,A,B,C)
\tkzDrawPolygon[dashed](I,J,K)
\tkzDrawSegments(S,M S,N S,B J,H N,H)
\tkzDrawSegments[dashed](A,C M,N)
\tkzDrawPoints[size=5,fill=black](A,B,C,S,I,J,K)
\tkzLabelPoints[below](A,B,M,N,K,H)
\tkzLabelPoints[above](S)
\tkzLabelPoints[right](C,J)
\tkzLabelPoints[left](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 120,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_120.png",
    Code = @"\begin{tikzpicture}[line cap=round, line join=round,font=\footnotesize,>=stealth, scale=1.1]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B, 4/0/D, 3/-1.5/C, 1/2.5/A}
\tkzDefBarycentricPoint(B=0.2,D=0.8)\tkzGetPoint{K}
\tkzDefMidPoint(A,C)\tkzGetPoint{M}
\tkzDefMidPoint(B,C)\tkzGetPoint{N}
\tkzInterLL(N,K)(C,D)\tkzGetPoint{I}
\tkzInterLL(I,M)(A,D)\tkzGetPoint{H}
\tkzDrawSegments[dashed](B,D M,K N,I)
\tkzDrawSegments(A,B B,C C,I I,M A,D A,C M,N)
\tkzDrawPoints[fill=black](A,B,C,D,M,N,K,H,I)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B,M)
\tkzLabelPoints[below](C,K)
\tkzLabelPoints[below right](D)
\tkzLabelPoints[above right](I,H)
\tkzLabelPoints[below left](N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 121,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_121.png",
    Code = @"\begin{tikzpicture}
[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/B,3/-2/C,5/0/D,2/4.5/A}
\coordinate (E) at ($(B)!1/3!(D)$);
\coordinate (F) at ($(C)!2/3!(D)$);
\coordinate (P) at ($(A)!1.3/3!(B)$);
\coordinate (Q) at ($(A)!3/5!(C)$);
\tkzInterLL(A,E)(P,D)\tkzGetPoint{M}
\tkzInterLL(A,F)(Q,D)\tkzGetPoint{N}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(A,C A,F P,Q Q,D)
\tkzDrawSegments[dashed](B,D A,E E,F P,D)
\tkzDrawPoints[fill=black](A,B,C,D,Q,P,M,N,E,F)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,E)
\tkzLabelPoints[left](B,P,Q)
\tkzLabelPoints[right](D,F)
\tkzLabelPoints[right](M)
\tkzLabelPoints[right](N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 122,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_122.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/B, 2/-2/C, 6/0/D, 2/4/A}
\tkzDefMidPoint(A,D)\tkzGetPoint{I}
\tkzDefMidPoint(B,C)\tkzGetPoint{J}
\tkzDefBarycentricPoint(A=1,B=3)
\tkzGetPoint{M}
\tkzDefBarycentricPoint(A=3,C=2)
\tkzGetPoint{N}
\tkzInterLL(D,N)(C,I)\tkzGetPoint{F}
\tkzInterLL(D,M)(B,I)\tkzGetPoint{E}
\tkzLabelPoints[below left](B,J)
\tkzLabelPoints[above left](M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,E)
\tkzLabelPoints[right](D,N)
\tkzLabelPoints[above right](I,F)
\tkzDrawPoints[fill=black](A,B,C,D,I,J,M,N,E,F)
\tkzDrawSegments[dashed](B,D B,I D,J M,D I,J E,F)
\tkzDrawSegments(A,C A,B A,D C,D B,C C,I A,J M,N N,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 123,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_123.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/B, 2/-2/C, 6/0/D, 2/4/A, 3/-1/I}
\tkzDefBarycentricPoint(A=1,B=2)
\tkzGetPoint{M}
\tkzDefBarycentricPoint(A=3,C=2)
\tkzGetPoint{N}
\tkzInterLL(M,N)(C,B)\tkzGetPoint{H}
\tkzInterLL(I,H)(B,D)\tkzGetPoint{E}
\tkzInterLL(I,H)(C,D)\tkzGetPoint{F}
\tkzLabelPoints[left](H)
\tkzLabelPoints[below left](B,I)
\tkzLabelPoints[above left](M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C,E)
\tkzLabelPoints[right](D,N)
\tkzLabelPoints[below right](F)
\tkzDrawPoints[fill=black](A,B,C,D,M,N,H,I,E,F)
\tkzDrawSegments[dashed](B,D H,F M,E M,I N,I)
\tkzDrawSegments(A,C A,B A,D C,D C,H N,H N,F)
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=124): PDF có nhưng không tạo được PNG

new TikzItem2
{
    Id = 125,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_125.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\scriptsize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A, 1/-1.5/D, 6/0/B, 4/-2.5/C, 2/4/S}
\tkzInterLL(A,C)(B,D)\tkzGetPoint{H}
\tkzInterLL(A,B)(C,D)\tkzGetPoint{K}
\tkzInterLL(A,D)(B,C)\tkzGetPoint{L}
\tkzLabelPoints[above](S)
\tkzLabelPoints[above left](A)
\tkzLabelPoints[below left](D)
\tkzLabelPoints[below](H,K,L)
\tkzLabelPoints[right](B,C)
\tkzDrawPoints[fill=black](A,B,C,D,S,H,K,L)
\tkzDrawSegments[dashed](B,K A,C B,D S,H S,A A,D C,D)
\tkzDrawSegments(S,C S,B S,D D,K S,K B,C D,L C,L S,L)
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=126): PDF có nhưng không tạo được PNG

new TikzItem2
{
    Id = 127,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_127.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/B, 2/-2/C, 6/0/D, 2/4/A, 3/-1/I}
\tkzDefBarycentricPoint(A=1,B=2)
\tkzGetPoint{M}
\tkzDefBarycentricPoint(A=3,C=2)
\tkzGetPoint{N}
\tkzInterLL(M,N)(C,B)\tkzGetPoint{H}
\tkzLabelPoints[left](H)
\tkzLabelPoints[below left](B,I)
\tkzLabelPoints[above left](M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](C)
\tkzLabelPoints[right](D,N)
\tkzDrawPoints[fill=black](A,B,C,D,M,N,H,I)
\tkzDrawSegments[dashed](B,D H,I N,I M,I)
\tkzDrawSegments(A,C A,B A,D C,D C,H N,H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 128,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_128.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.8]
\def \xa{2} 
\def \xb{-3}
\def \y{6}
\def \z{5}
\coordinate (A) at (0,0);
\coordinate (B)at ($(\xa,\xb)$);
\coordinate (C) at ($(\y,0)$);
\coordinate (N) at ($0.5*(B)+0.5*(C)$);
\coordinate (H) at ($0.7*(N)+0.3*(A)$);
\coordinate (S) at ($(H)+(0,\z)$);
\coordinate (M) at ($0.5*(S)+0.5*(A)$);
\coordinate (J) at ($0.6*(H)+0.4*(S)$);
\draw (S)--(C)--(B)--(A)--(S)--(B) (S)--(A) (S)--(M);
\draw [dashed] (C)--(A)--(N) (S)--(H) (M)--(J);
\tkzMarkRightAngles(S,M,J A,N,B S,H,A)
\tkzMarkSegment [mark=|](A,B)
\tkzMarkSegment [pos=0.7,mark=|](A,C)
\tkzMarkSegment [pos=0.3, mark=|](B,C) 
\tkzLabelPoints[below](B,H,N)
\tkzLabelPoints[right](C,J)
\tkzLabelPoints[left](M,A)
\tkzLabelPoints[above](S)
\tkzDrawPoints(A,B,C,S,M,H,J)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 129,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_129.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/C, 4/0/A, 6/1.5/B, 0/4/h};
\coordinate (K) at ($(B)+(C)-(A)$);
\coordinate (S) at ($(K)+(h)$);
\coordinate (I) at ($(S)!0.5!(A)$);
\coordinate (O) at ($(B)!0.5!(C)$);
\coordinate (J) at ($(A)!0.5!(B)$);
\coordinate (H) at ($(I)!0.4!(J)$);
\tkzDrawPolygon(S,B,A,C);
\tkzDrawSegments(S,A I,J);
\tkzDrawSegments[dashed](I,O B,C O,J O,H);
\tkzDrawPoints[fill=black](S,A,B,C,H,I,O,J);
\tkzLabelPoints[above](S);
\tkzLabelPoints[below](C,A,O);
\tkzLabelPoints[right](B,J);
\tkzLabelPoints[above right](I,H);
\tkzMarkRightAngles(B,A,C S,B,A S,C,A I,O,C O,H,J O,J,A);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 130,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_130.png",
    Code = @"\begin{tikzpicture}[>=stealth,line cap=round,line join=round,x=1cm,y=1cm,scale = 1, font = \footnotesize]
\tkzDefPoint(0,0){A}
\tkzDefShiftPoint[A](0:5){B}
\tkzDefShiftPoint[A](-20:4){C}
\tkzDefBarycentricPoint(A=1,B=1,C=1)
\tkzGetPoint{O}
\tkzDefShiftPoint[O](90:4){D}
\tkzDefMidPoint(A,D)
\tkzGetPoint{M}
\tkzDefMidPoint(B,C)
\tkzGetPoint{N}
\tkzDefMidPoint(M,N)
\tkzGetPoint{I}
\tkzDrawSegments(A,C B,C D,A D,B D,C)
\tkzDrawSegments[dashed](A,B M,N A,I A,N)
\tkzDrawPoints[fill = black](A,B,C,D,M,N,I)
\tkzLabelPoints[below](A,B,C,N,O)
\tkzLabelPoints[above](D,M,I)
\tkzMarkRightAngles(A,M,I I,N,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 131,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_131.png",
    Code = @"\begin{tikzpicture}
\tkzInit[xmin=-3.5,xmax=7.5,ymin=-3.5,ymax=6.5]
\clip (-3.5,-3.5) rectangle (7.5,6.5);
\tkzDefPoints{0/0/A,5/0/C,1.5/-2.5/B,2/4/S} 
\tkzDefMidPoint(B,C)\tkzGetPoint{M}
\tkzDefMidPoint(A,B)\tkzGetPoint{N}
\tkzInterLL(A,M)(C,N) \tkzGetPoint{H}
\tkzDrawSegments(S,A S,B S,C A,B B,C)
\tkzDrawSegments[dashed](A,C A,M C,N S,H)
\tkzDrawPoints[color=red](A,B,C,M,N,H)
\tkzLabelPoints[left=3pt](B,N)
\tkzLabelPoints[right](M,C)
\tkzLabelPoints[above](A) 
\tkzLabelPoints[above](S) 
\tkzLabelPoints[below](H) 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 132,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_132.png",
    Code = @"\begin{tikzpicture}[scale=1,>=stealth, font=\footnotesize, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1.2/-1.6/B,4.5/0/C}
\tkzCentroid(A,B,C)\tkzGetPoint{H}
\coordinate (S) at ($(H)+(0,3.5)$);
\coordinate (I) at ($(B)!1/2!(C)$);
\tkzDrawPolygon(A,B,C,S)
\tkzDrawSegments(S,B)
\tkzDrawSegments[dashed](I,A A,C S,H)
\tkzDrawPoints[fill=black](A,B,C,S,H,I)
\tkzMarkRightAngles[size=0.14](A,I,B S,H,A)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B,H,I)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 133,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_133.png",
    Code = @"\begin{tikzpicture}[scale=0.5]
\tkzDefPoints{0/0/A,2/7/S,7/0/C,3/-2/B}
\coordinate (H) at ($(S)+(0,-7.6)$);
\tkzDrawSegments(C,B C,S S,A A,B S,B)
\tkzDrawSegments[dashed](A,C S,H)
\tkzDrawSegments[dashed](B,C)
\tkzLabelPoints[below](B)
\tkzLabelPoints[right](C,H)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above](S)
\tkzMarkRightAngle(S,H,A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 134,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_134.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=triangle 45,x=1cm,y=1cm]
\clip(-1,-3) rectangle (6,5);
\draw [shift={(3,-1)},color=black,fill=black,fill opacity=0.10000000149011612] (0,0) -- (101.30993247402021:0.6) arc (101.30993247402021:161.565051177078:0.6) -- cycle;
\draw [dash pattern=on 1pt off 1pt] (0,0)-- (5,0);
\draw (0,0)-- (1,-2);
\draw (1,-2)-- (5,0);
\draw [dash pattern=on 1pt off 1pt] (3,-1)-- (0,0);
\draw [dash pattern=on 1pt off 1pt] (2.01,-0.67)-- (2,4);
\draw (2,4)-- (0,0);
\draw (2,4)-- (1,-2);
\draw (2,4)-- (5,0);
\draw (2,4)-- (3,-1);
\begin{normalsize}
\draw [fill=black] (0,0) circle (2.5pt);
\draw[color=black] (-0.38,0.11) node {$A$};
\draw [fill=black] (5,0) circle (2.5pt);
\draw[color=black] (5.16,0.43) node {$C$};
\draw [fill=black] (1,-2) circle (2.5pt);
\draw[color=black] (0.74,-2.39) node {$B$};
\draw [fill=black] (3,-1) circle (2.5pt);
\draw[color=black] (3.08,-1.27) node {$M$};
\draw [fill=black] (2.01,-0.67) circle (2.5pt);
\draw[color=black] (1.82,-0.93) node {$H$};
\draw [fill=black] (2,4) circle (2.5pt);
\draw[color=black] (2,4.55) node {$S$};
\end{normalsize}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 135,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_135.png",
    Code = @"\begin{tikzpicture}[scale=1,>=stealth, font=\footnotesize, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1/-1.5/C,4/0/A}
\coordinate (H) at ($(B)!0.5!(A)$);
\coordinate (S) at ($(H)+(0,3)$);
\tkzDrawPolygon(S,A,C,B)
\tkzDrawSegments(S,C B,C)
\tkzDrawSegments[dashed](S,H)
\tkzDrawSegments[dashed](B,A)
\tkzDrawPoints[fill=black,size=4](A,B,C,S,H)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](H,A,C)
\tkzLabelPoints[left](B)
\tkzMarkRightAngles[size=0.16](A,S,B)
\node at (0,-1) {$2a$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 136,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_136.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\tkzDefPoints{0/0/A, 5/0/B, 2/-1.5/C, 1.3/5/S}
\coordinate (I) at ($(S)!0.5!(B)$);
\coordinate (J) at ($(S)!0.5!(C)$);
\tkzDrawSegments(S,A S,B S,C A,C B,C A,J I,J)
\tkzDrawSegments[dashed](A,B A,I)
\tkzDrawPoints(S,A,B,C,I,J)
\tkzLabelPoints[above left](A,J)
\tkzLabelPoints[above right](B,I)
\tkzLabelPoints[below](C)
\tkzLabelPoints[above](S)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 137,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_137.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A, 3/-3/B, 6/0/C}
\coordinate (M) at ($(B)!.5!(C)$);% M là trung điểm BC
\coordinate (H) at ($(A)!.67!(M)$);
\coordinate (S) at ($(H)+(0,5)$);
\tkzDrawSegments[dashed](A,C)
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(S,A A,B)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](C)
\tkzLabelPoints[below](B)
\tkzLabelPoints[above](S)
\tkzMarkRightAngle(A,S,B)
\tkzMarkRightAngle(B,S,C)
\tkzMarkRightAngle(A,S,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 138,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_138.png",
    Code = @"\begin{tikzpicture}[scale=.6]
\tkzDefPoints{0/0/B, 4/-2/C, 6/0/D}
\coordinate (I) at ($(C)!.5!(D)$);
\coordinate (E) at ($(B)!.67!(I)$); 
\coordinate (A) at ($(E)+(0,5)$);
\coordinate (M) at ($(A)!.5!(B)$);
\coordinate (N) at ($(C)!.5!(B)$);
\coordinate (P) at ($(C)!.5!(D)$);
\coordinate (Q) at ($(A)!.5!(D)$);
\coordinate (R) at ($(B)!.5!(D)$);
\coordinate (S) at ($(A)!.5!(C)$);
\tkzDrawPoints(A,B,C,D,M,N,P,Q,R,S)
\tkzDrawSegments[dashed](B,D R,M N,P R,P R,Q M,Q N,R)
\tkzDrawPolygon(A,B,C)
\tkzDrawPolygon(M,N,S)
\tkzDrawPolygon(P,Q,S)
\tkzDrawSegments(D,C D,A)
\tkzLabelPoints[left](M,B,S)
\tkzLabelPoints[right](P,Q,D)
\tkzLabelPoints[below](N,C,R)
\tkzLabelPoints[above](A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 139,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_139.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\tkzDefPoints{2/3/A,4/0/B,8/3/C,4.667/2/O,6/1.5/E,4.667/9/S}%Chèn điểm
\tkzLabelPoints(E,B)%Nhãn của điểm
\tkzDrawPoints(O)%Vẽ điểm
\tkzLabelPoints[above](S)
\tkzLabelPoints[left](A)
\tkzLabelPoints[below](O)
\tkzLabelPoints[right](C)
\tkzDrawSegments[dashed](A,C A,E A,O S,O)% Đoạn thẳng
\tkzDrawSegments(S,A S,B S,C A,B B,C)% Đoạn thẳng
\tkzMarkRightAngles(A,E,B S,O,A) %Đánh dấu góc vuông
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 140,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_140.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A,1.3/-1.6/B,4.5/0/C,1/3.5/S}
\coordinate (M) at ($(A)!0.5!(S)$);
\coordinate (N) at ($(S)!0.5!(B)$);
\tkzDrawPolygon(A,B,C,S)
\tkzDrawSegments(S,B M,N C,N)
\tkzDrawSegments[dashed](A,C C,M)
\tkzDrawPoints[fill=black,size=4](A,B,C,S,M,N)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B)
\tkzLabelPoints[left](A,M)
\tkzLabelPoints[below left](N)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 141,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_141.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round, >=stealth,scale=1]
\def \xa{-3} 
\def \xb{-2}
\def \y{5}
\def \z{5}
\coordinate (A) at (0,0);
\coordinate (D) at ($(A)+(\xa,\xb)$);
\coordinate (B) at ($(A)+(\y,0)$);
\coordinate (C) at ($ (D)+(B)-(A) $);
\coordinate (O) at ($ 0.5*(B)+0.5*(D)-0.5*(A) $);
%\coordinate (S) at ($ (O)+(0,\z) $);
\coordinate (E) at ($ 0.5*(C)+0.5*(B)$);
\coordinate (H) at ($ 0.3333*(A)+0.6666*(E)$);
\coordinate (S) at ($ (H)+(0,\z)$);
\coordinate (B') at ($ 0.5*(S)+0.5*(B)$);
\coordinate (A') at ($ 0.5*(S)+0.5*(A)$);
%\coordinate (S) at ($ (A)+(0,\z) $);
%\coordinate (M) at ($ (A)+(0,0.6666*\z) $);
%\coordinate (N) at ($ (A)+(0.33333*\y,0.66666*\z) $);
\draw [dashed, line width=1.2pt,blue] (B)--(A)(A')--(B') ;
\draw[line width=1.2pt,blue] (A)--(C)--(B) (A)--(S)--(C) (S)--(B) (A')--(C)--(B') ;
\tkzDrawPoints(A,B,C,E,S,A',B')
\tkzLabelPoints[right](B')
\tkzLabelPoints[below right](C)
%\tkzLabelPoints[above](S)
\tkzLabelPoints[above](S)
\tkzLabelPoints[above left](A)
\tkzLabelPoints[below right](B)
%\tkzLabelPoints[below left](H)
%\tkzLabelPoints[below left](O)
%\tkzLabelPoints[above right](N)
\tkzLabelPoints[left](A')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 142,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_142.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tkzDefPoints{0/0/A, 4/-2/B, 5/0/C, 3/3/D}
%\coordinate (M) at ($(A)!.5!(B)$);
\tkzCentroid(A,B,C)\tkzGetPoint{M}
\tkzCentroid(A,C,D)\tkzGetPoint{N}
\tkzCentroid(A,B,D)\tkzGetPoint{P}
\tkzCentroid(B,C,D)\tkzGetPoint{Q}
%\coordinate (I) at ($(A)!.4!(M)$);
%\coordinate (K) at ($(A)!.4!(C)$);
%\coordinate (H) at ($(A)!.4!(S)$);
\tkzDrawSegments(A,D D,B D,C A,B B,C)
\tkzDrawSegments[dashed](A,C M,N M,P M,Q N,P N,Q P,Q)
\tkzLabelPoints[below](A,B,C,M,P)
\tkzLabelPoints[above](D,N,Q)
%\tkzLabelPoints[right](D)
%\draw ($(A)!.5!(I)$) node[right]{$x$};
%\tkzMarkAngles[size=0.5cm](S,C,H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 143,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_143.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tkzDefPoints{0/0/B,1/-1/C, 4/0/D, 0/4/K}
\tkzDefMidPoint(D,C)
\tkzGetPoint{M}
\tkzDefMidPoint(B,C)
\tkzGetPoint{N}
\tkzInterLL(D,N)(B,M)
\tkzGetPoint{O}
\tkzDefPointBy[translation = from B to K](O)
\tkzGetPoint{A}
\tkzMarkRightAngle(A,M,D)
\tkzMarkRightAngle(B,M,C)
\tkzMarkRightAngle(A,O,M)
\tkzDrawSegments(A,B A,C A,D A,M B,C C,D)
\tkzDrawSegments[dashed](B,D A,O B,M)
\tkzLabelPoints[above right](A)
\tkzLabelPoints[below](B,M,O)
\tkzLabelPoints[below right](C,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 144,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_144.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/A,1.3/-1.6/B,4.5/0/C,1/3/S}
\coordinate (M) at ($(A)!0.5!(S)$);
\coordinate (N) at ($(S)!0.5!(B)$);
\tkzDrawPolygon(A,B,C,S)
\tkzDrawSegments(S,B M,N C,N)
\tkzDrawSegments[dashed](A,C C,M)
\tkzDrawPoints[fill=black,size=4](A,B,C,S,M,N)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B)
\tkzLabelPoints[left](A,M)
\tkzLabelPoints[below left](N)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 145,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_145.png",
    Code = @"\begin{tikzpicture}[scale=.6]
\tkzDefPoints{0/0/A, -2/-2/B, 3/-2/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (S) at ($(A)+(0.5,5)$);
\coordinate (H) at ($(S)!.5!(B)$);
\tkzLabelPoints[above left](H)
\coordinate (K) at ($(S)!.5!(D)$);
\tkzLabelPoints[right](K)
\coordinate (O) at ($(A)!.5!(C)$);
\tkzLabelPoints[below](O)
\tkzDrawSegments[dashed](S,A A,B A,D B,D A,C O,H O,K H,K A,H A,K)
\tkzDrawPolygon(S,C,D)
\tkzDrawSegments(S,B B,C)
\tkzLabelPoints[left](A,B)
\tkzLabelPoints[right](C,D)
\tkzLabelPoints[above](S)
\tkzMarkSegments[mark=|](S,H H,B)
\tkzMarkSegments[mark=||](S,K K,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 146,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_146.png",
    Code = @"\begin{tikzpicture}[scale=.6]
\tkzDefPoints{0/0/A, -2/-2/B, 3/-2/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (S) at ($(A)+(0.5,4)$);
\coordinate (H) at ($(S)!.5!(B)$);
\tkzLabelPoints[above left](H)
\coordinate (K) at ($(S)!.5!(D)$);
\tkzLabelPoints[right](K)
\coordinate (O) at ($(A)!.5!(C)$);
\tkzLabelPoints[below](O)
\tkzDrawSegments[dashed](S,A A,B A,D B,D A,C O,H O,K H,K A,H A,K)
\tkzDrawPoints[size=6,fill=black](A,O,H,K,S,B,C,D)
\tkzDrawPolygon(S,C,D)
\tkzDrawSegments(S,B B,C)
\tkzLabelPoints[left](A,B)
\tkzLabelPoints[right](C,D)
\tkzLabelPoints[above](S)
\tkzMarkSegments[mark=|](S,H H,B)
\tkzMarkSegments[mark=||](S,K K,D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 147,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_147.png",
    Code = @"\begin{tikzpicture}[scale=.6]
\tkzDefPoints{0/0/A, 2/-2/B, 6/0/C, 2/4/S}
\tkzDefMidPoint(A,B)\tkzGetPoint{C'}
\tkzDefMidPoint(C,B)\tkzGetPoint{A'} 
\tkzDefMidPoint(A,C)\tkzGetPoint{B'}
\tkzInterLL(A,A')(B,B')\tkzGetPoint{G}
\tkzDrawSegments[dashed](S,B' A,A' B,B' C,C' A,C A',B' B',C' C',A')
\tkzDrawPolygon(A,B,S)
\tkzDrawSegments(S,C' S,A' S,C B,C)
\tkzDrawPoints(S,A,B,C,B',A',C',G)
\tkzLabelPoints[left](A)
\tkzLabelPoints[above left](B')
\tkzLabelPoints[right](C)
\tkzLabelPoints[below](B,G)
\tkzLabelPoints[below left](C')
\tkzLabelPoints[below right](A')
\tkzLabelPoints[above](S)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 148,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_148.png",
    Code = @"\begin{tikzpicture}[scale=0.8]
\tkzDefPoints{0/0/A,1/-2/B,5/0/C}
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\coordinate (D) at ($(G)+(0,3)$);
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(B)!0.5!(C)$);
\tkzDrawPoints[size=5,fill=black](A,B,C,D,M,N,G)
\tkzDrawSegments(D,A D,B D,C A,B B,C)
\tkzDrawSegments[dashed](A,C D,G A,N C,M)
\tkzLabelPoints[above](D)
\tkzLabelPoints[left](A,M)
\tkzLabelPoints[right](C)
\tkzLabelPoints[below](B,G,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 149,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_149.png",
    Code = @"\begin{tikzpicture}[scale=0.6, line join = round, line cap = round]
\tkzDefPoints{0/0/B,7/0/C,2/-3/A,3/4/D}
\tkzDrawPolygon(D,B,A,C)
\tkzDrawSegments(D,A)
\tkzDrawSegments[dashed](B,C)
\tkzDrawPoints(D,B,C,A)
\tkzLabelPoints[above](D)
\tkzLabelPoints[below](A)
\tkzLabelPoints[left](B)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=150): PDF có nhưng không tạo được PNG

new TikzItem2
{
    Id = 151,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_151.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join = round, line cap = round]
\tkzDefPoints{0/0/A,5/0/B,2/-2/C,1.4/-0.5/H}
\coordinate (S) at ($(H)+(0,3.5)$);
\coordinate (A') at ($(A)!0.6!(S)$);
\coordinate (B') at ($(B)!0.4!(S)$);
\coordinate (C') at ($(C)!0.45!(S)$);
\tkzDrawSegments(S,A S,B S,C A,C B,C A',C' C',B')
\tkzDrawSegments[dashed](A,B A',B')
\tkzDrawPoints(A,B,C,S,A',B',C')
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](C)
\tkzLabelPoints[left](A,A',C')
\tkzLabelPoints[right](B,B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 152,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_152.png",
    Code = @"\begin{tikzpicture}[scale=0.9]
\tkzDefPoints{0/0/A,1/-2/B,5/0/C}
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\coordinate (S) at ($(G)+(0,3)$);
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(B)!0.5!(C)$);
\tkzDrawPoints[size=5,fill=black](A,B,C,S,M,N,G)
\tkzDrawSegments(S,A S,B S,C A,B B,C)
\tkzDrawSegments[dashed](A,C S,G A,N C,M)
\tkzLabelPoints[above](S)
\tkzLabelPoints[left](A,M)
\tkzLabelPoints[right](C)
\tkzLabelPoints[below](B,G,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 153,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_153.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tkzDefPoints{0/0/A,1/-2/B,5/0/C}
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\coordinate (S) at ($(G)+(0,4)$);
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(B)!0.5!(C)$);
\tkzDrawPoints[size=5,fill=black](A,B,C,S,M,N,G)
\tkzMarkAngles[size=0.6,arc=ll,mark=|](S,C,G)
\tkzMarkAngles[size=0.5,arc=l,mark=||](S,N,G)
\tkzDrawSegments(S,A S,B S,C A,B B,C S,M S,N)
\tkzDrawSegments[dashed](A,C S,G A,N C,M)
\tkzLabelPoints[above](S)
\tkzLabelPoints[left](A,M)
\tkzLabelPoints[right](C)
\tkzLabelPoints[below](B,G,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 154,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_154.png",
    Code = @"\begin{tikzpicture}[scale=0.5]
\tkzDefPoints{0/0/B,1/-2/A,5/0/C,3/3.5/S}
\tkzDrawPoints[size=5,fill=black](A,B,C,S)
\tkzDrawSegments(A,B A,C S,A S,B S,C)
\tkzDrawSegments[dashed](B,C)
\tkzLabelPoints[below](A,C)
\tkzLabelPoints[left](B)
\tkzLabelPoints[above](S)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 155,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_155.png",
    Code = @"\begin{tikzpicture}[scale=.4]
\tkzDefPoints{0/0/A, 4/-2/B, 6/0/C}
\coordinate (M) at ($(B)!.5!(C)$);
\coordinate (H) at ($(A)!.67!(M)$);
\coordinate (S) at ($(H)+(0,5)$);
\coordinate (N) at ($(S)!.5!(C)$);
\coordinate (P) at ($(B)!.5!(S)$);
\coordinate (Q) at ($(S)!.5!(A)$);
\coordinate (R) at ($(B)!.5!(A)$);
\coordinate (K) at ($(A)!.5!(C)$);
\tkzDrawSegments[dashed](A,C Q,C)
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(S,A A,B B,Q)
\tkzFillPolygon[color=black!25, fill opacity=0.5](B,Q,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 156,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_156.png",
    Code = @"\begin{tikzpicture}[scale=.4]
\tkzDefPoints{0/0/A, 4/-2/B, 6/0/C}
\coordinate (M) at ($(B)!.5!(C)$);
\coordinate (H) at ($(A)!.67!(M)$);
\coordinate (S) at ($(H)+(0,5)$);
\coordinate (N) at ($(S)!.5!(C)$);
\coordinate (P) at ($(B)!.5!(S)$);
\coordinate (Q) at ($(S)!.5!(A)$);
\coordinate (R) at ($(B)!.5!(A)$);
\coordinate (K) at ($(A)!.5!(C)$);
\tkzDrawSegments[dashed](A,C)
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(S,A A,B A,P P,C)
\tkzFillPolygon[color=black!25, fill opacity=0.5](C,P,A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 157,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_157.png",
    Code = @"\begin{tikzpicture}[scale=.4]
\tkzDefPoints{0/0/A, 4/-2/B, 6/0/C}
\coordinate (M) at ($(B)!.5!(C)$);
\coordinate (H) at ($(A)!.67!(M)$);
\coordinate (S) at ($(H)+(0,5)$);
\coordinate (N) at ($(S)!.5!(C)$);
\coordinate (P) at ($(B)!.5!(S)$);
\coordinate (Q) at ($(S)!.5!(A)$);
\coordinate (R) at ($(B)!.5!(A)$);
\coordinate (K) at ($(A)!.5!(C)$);
\tkzDrawSegments[dashed](A,C A,N)
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(S,A A,B B,N)
\tkzFillPolygon[color=black!25, fill opacity=0.5](A,B,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 158,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_158.png",
    Code = @"\begin{tikzpicture}[scale=.4]
\tkzDefPoints{0/0/A, 4/-2/B, 6/0/C}
\coordinate (M) at ($(B)!.5!(C)$);
\coordinate (H) at ($(A)!.67!(M)$);
\coordinate (S) at ($(H)+(0,5)$);
\coordinate (N) at ($(S)!.5!(C)$);
\coordinate (P) at ($(B)!.5!(S)$);
\coordinate (Q) at ($(S)!.5!(A)$);
\coordinate (R) at ($(B)!.5!(A)$);
\coordinate (K) at ($(A)!.5!(C)$);
\tkzDrawSegments[dashed](A,C S,K K,B)
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(S,A A,B)
\tkzFillPolygon[color=black!25, fill opacity=0.5](S,B,K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 159,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_159.png",
    Code = @"\begin{tikzpicture}[scale=.4]
\tkzDefPoints{0/0/A, 4/-2/B, 6/0/C}
\coordinate (M) at ($(B)!.5!(C)$);
\coordinate (H) at ($(A)!.67!(M)$);
\coordinate (S) at ($(H)+(0,5)$);
\coordinate (N) at ($(S)!.5!(C)$);
\coordinate (P) at ($(B)!.5!(S)$);
\coordinate (Q) at ($(S)!.5!(A)$);
\coordinate (R) at ($(B)!.5!(A)$);
\coordinate (K) at ($(A)!.5!(C)$);
\tkzDrawSegments[dashed](A,C R,C)
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(S,A A,B S,R)
\tkzFillPolygon[color=black!25, fill opacity=0.5](S,R,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 160,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_160.png",
    Code = @"\begin{tikzpicture}[scale=.4]
\tkzDefPoints{0/0/A, 4/-2/B, 6/0/C}
\coordinate (M) at ($(B)!.5!(C)$);
\coordinate (H) at ($(A)!.67!(M)$);
\coordinate (S) at ($(H)+(0,5)$);
\coordinate (N) at ($(S)!.5!(C)$);
\coordinate (P) at ($(B)!.5!(S)$);
\coordinate (Q) at ($(S)!.5!(A)$);
\coordinate (R) at ($(B)!.5!(A)$);
\coordinate (K) at ($(A)!.5!(C)$);
\tkzDrawSegments[dashed](A,C A,M)
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(S,A A,B S,M)
\tkzFillPolygon[color=black!25, fill opacity=0.5](S,M,A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 161,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_161.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round]
\tkzDefPoints{0/0/A, 1/-1/B, 2/0/C, 1.3/1.5/D}
\draw [dashed](A) -- (C);
\tkzDrawPolygon(A,B,C,D)
\draw (A)-- (B);
\draw (B) -- (D);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 162,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_162.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round]
\tkzDefPoints{0/0/A, 1/-1/B, 3.5/-0.25/C, 2/2/D}
\tkzDefMidPoint(B,C)
\tkzGetPoint{M}
\tkzDefMidPoint(B,D)
\tkzGetPoint{N}
\tkzDrawPoints(M,N)
\draw [dashed](A) -- (C) (A)--(M);
\tkzDrawPolygon(A,B,C,D)
\draw (A)-- (B) (A)--(N)--(M);
\draw (B) -- (D);
\tkzLabelPoints(B,C,M)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](D,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 163,
    Title = "Hình minh họa Toán học",
    Category = "Chóp tam giác thường",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Chop_tam_giac_thuong/choptamgiacthuong_163.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round]
\tkzDefPoints{0/0/A, 1/-1/B, 3.5/-0.25/C, 2/2/D}
\tkzDefMidPoint(B,C)
\tkzGetPoint{M}
\tkzDefMidPoint(B,D)
\tkzGetPoint{N}
\tkzDrawPoints(M,N)
\draw [dashed](A) -- (C) (A)--(M);
\tkzDrawPolygon(A,B,C,D)
\draw (A)-- (B) (A)--(N)--(M);
\draw (B) -- (D);
\tkzLabelPoints(B,C,M)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](D,N)
\end{tikzpicture}"
},

