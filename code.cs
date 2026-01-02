new TikzItem2
{
    Id = 1,
    Title = "Đồ thị hàm số có 2 tiệm cận ngang",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số y=2x/√(x²+1) có hai tiệm cận ngang y=2 và y=-2.",
    ImagePath = "Tiem_can/Tiemcan1.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.5,>=stealth]
 \draw[->] (-4,0)--(4,0) node[below]{$x$};
 \draw[->] (0,-3)--(0,3) node[right]{$y$};
 \draw (0,0) node[above left]{$O$};
 \draw[line width = 1pt,domain=-3.7:3.7] plot(\x,{2*(\x)/((\x)^2+1)^0.5});
 \draw[fill=black] (0,2) circle(1.5pt) (0,-2) circle(1.5pt);
 \draw[dashed] (-4,-2)node[below]{\footnotesize $y=-2$}--(4,-2);
 \draw[dashed] (-4,2)--(4,2)node[above]{\footnotesize $y=2$};
 \node[right] at (0,1.5) {\footnotesize $2$};
 \node[right] at (0,-1.5) {\footnotesize $-2$};
 \node[below] at (0,-3) {\footnotesize Có TCN $y=2$, $y=-2$};
 \end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Đồ thị hàm số mũ có tiệm cận ngang",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số y=2⁻ˣ+1 có tiệm cận ngang y=1, đi qua điểm (0, 2).",
    ImagePath = "Tiem_can/Tiemcan2.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.5,>=stealth]
 \draw[->] (-2,0)--(4,0) node[below]{$x$};
 \draw[->] (0,-1.5)--(0,3.5) node[right]{$y$};
 \draw (0,0) node[below left]{$O$};
 \draw[line width = 1pt,domain=-1.2:3.7] plot(\x,{2^(-\x)+1});
 \draw[fill=black] (0,1) circle(1.5pt);
 \draw[dashed] (-2,1)--(3.9,1)node[above]{\footnotesize $y=1$};
 \node[left] at (0,1.5) {\footnotesize $1$};
 \node[below] at (0,-1.5) {\footnotesize Có TCN $y=1$};
 \end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Đồ thị hàm hữu tỉ có 2 tiệm cận đứng",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số y=x/(x²-1) có hai tiệm cận đứng x=-1 và x=1, đi qua gốc tọa độ.",
    ImagePath = "Tiem_can/Tiemcan3.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.7,>=stealth]
  \draw[->] (-3,0)--(3,0) node[below]{$x$};
  \draw[->] (0,-2.5)--(0,2.5) node[right]{$y$};
  \draw (0,0) node[below left]{$O$};
  \draw[line width = 1.2pt,domain=-3:-1.23]
  plot(\x, {(\x)/((\x)^2-1)});
  \draw[line width = 1.2pt,domain=-0.8:0.8]
  plot(\x, {(\x)/((\x)^2-1)});
  \draw[line width = 1.2pt,domain=1.25:3]
  plot(\x, {(\x)/((\x)^2-1)});
  \draw[fill=black] (1,0) circle(1.5pt) (-1,0) circle(1.5pt);
  \draw[dashed] (1,-2.5)--(1,2.5);
  \draw[dashed] (-1,-2.5)--(-1,2.5);
  \node[right] at (1,0.3) {\small $1$};
  \node[left] at (-1,0.3) {\small $-1$};
  \node[below] at (0,-2.5) {\footnotesize Có TCĐ $x=-1$ và $x=1$};
  \end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Tiệm cận xiên khi x→+∞",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số có tiệm cận xiên y=ax+b khi x→+∞, thỏa mãn lim[f(x)-(ax+b)]=0.",
    ImagePath = "Tiem_can/Tiemcan4.png",
    Code = @"\begin{tikzpicture}[scale=1,>=stealth, font=\footnotesize, line join=round, line cap=round]
\def\xmin{-3.5} \def\xmax{3}
\def\ymin{-0.5} \def\ymax{3}
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax);
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\fill (0,0) circle (1pt) node[shift={(-135:2.5mm)}]{$O$};
\node at (current bounding box.south) [below=-2pt] {a) $\lim\limits_{x \rightarrow+\infty}\left[f(x)-(ax+b)\right]=0$};
\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[red,thick,smooth,samples=300,domain=\xmin:\xmax]
(-3,0.8)..controls +(60:0.5) and +(180:.75)
..(-1.5,2)..controls +(0:.5) and +(180:.75)
..(0.5,1.3)..controls +(0:.75) and +(-160:.5)
..(2.8,1.8);
\draw[blue,smooth,samples=300,domain=\xmin:\xmax] plot(\x,{1/3*(\x)+0.75});
\path[blue] (-3,-0.25)--(0,0.75)node[below,sloped,pos=1.6]{$y=ax+b$};
\path[red] (-2.5,2)node[above right]{$y=f(x)$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Đồ thị có tiệm cận đứng và tiệm cận xiên",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số y=x-1+2/(x+1) có tiệm cận đứng x=-1 và tiệm cận xiên y=x-1.",
    ImagePath = "Tiem_can/Tiemcan5.png",
    Code = @"\begin{tikzpicture}[scale=.4, font=\footnotesize, line join=round, line cap=round, >=stealth]
\draw[->] (-6,0)--(0,0) node[below left]{$O$}--(6,0) node[below]{$x$};
\draw[->] (0,-8) --(0,6) node[right]{$y$};
\clip (-6,-8) rectangle (6,6);
\draw[violet] [domain=-0.8:6, samples=100,thick] %
plot (\x, {\x-1+ (2)/((\x)+1)});
\draw[violet] [domain=-6:-1.3, samples=100,thick] %
plot (\x, {\x-1+ (2)/((\x)+1)});
\draw[fill] (0,0) circle (1pt) (-1,0) circle (1pt) (-1,-2) circle (1pt) (1,0) circle (1pt)node[above] {$1$} (0,-1) circle (1pt)node[right] {$-1$};
\draw[domain=-8:7, samples=100] %
plot (\x, {\x-1});
\draw (-1,-8)--(-1,0)node[above left] {$-1$}--(-1,6);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Đồ thị có 2 tiệm cận đứng và 1 tiệm cận ngang",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số y=2x²/(x²-1) có hai tiệm cận đứng x=-1, x=1 và tiệm cận ngang y=2.",
    ImagePath = "Tiem_can/Tiemcan6.png",
    Code = @"\begin{tikzpicture}[scale=.7,>=stealth, font=\footnotesize, line join=round, line cap=round]
\def\xmin{-6} \def\xmax{6}
\def\ymin{-5} \def\ymax{7}
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax);
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\fill (0,0) circle (1pt) node[shift={(135:2.5mm)}]{$O$};
\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[thick,smooth,violet,samples=300,domain=(\xmin:-1.01)] plot(\x,{(2*(\x)^2)/((\x)^2-1)}); 
\draw[thick,smooth,violet,samples=300,domain=(-0.9:0.9)] plot(\x,{(2*(\x)^2)/((\x)^2-1)});
\draw[thick,smooth,violet,samples=300,domain=(1.1:\xmax)] plot(\x,{(2*(\x)^2)/((\x)^2-1)});
\draw[blue] (\xmin,2)--(\xmax,2); 
\draw[blue] (-1,\ymin)--(-1,\ymax); 
\draw[blue] (1,\ymin)--(1,\ymax); 
\foreach \x in {\xmin,...,\xmax}
\draw (\x,-0.1)--(\x,0.1);
\foreach \y in {\ymin,...,\ymax}
\draw (-0.1,\y)--(0.1,\y);
\node at (-5,2)[below]{$y=2$};
\node at (-1.2,-4)[left]{$x=-1$};
\node at (1.2,-4)[right]{$x=1$};
%\node at (-1,0)[shift={(-135:2.5mm)}]{$-1$};
%\node at (.5,0)[shift={(-75:2.5mm)}]{$\dfrac{1}{2}$};
%\node at (0,-1)[left]{$-1$};
%\node at (0,2)[shift={(135:2.5mm)}]{$2$}; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Đồ thị hàm hữu tỉ có 1 tiệm cận đứng",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số y=(x+1)/(x²-1) có tiệm cận đứng x=1, khử được nghiệm x=-1.",
    ImagePath = "Tiem_can/Tiemcan7.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.7,>=stealth]
  \draw[->] (-2,0)--(3,0) node[below]{$x$};
  \draw[->] (0,-2.5)--(0,2.5) node[right]{$y$};
  \draw (0,0) node[above left]{$O$};
  \draw[line width = 1.2pt,domain=-2:0.6]
  plot(\x, {(\x+1)/((\x)^2-1)});
  \draw[line width = 1.2pt,domain=1.4:3]
  plot(\x, {(\x+1)/((\x)^2-1)});
  \draw[fill=black] (1,0) circle(2pt);
  \draw[dashed] (1,-2.5)--(1,2.5);
  \node[right] at (1,0.3) {\small $1$};
  \node[below] at (0,-2.5) {\footnotesize Có TCĐ $x=1$};
  \end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Tiệm cận xiên khi x→-∞",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số có tiệm cận xiên y=ax+b khi x→-∞, thỏa mãn lim[f(x)-(ax+b)]=0.",
    ImagePath = "Tiem_can/Tiemcan8.png",
    Code = @"\begin{tikzpicture}[scale=1,>=stealth, font=\footnotesize, line join=round, line cap=round]
\def\xmin{-4} \def\xmax{2.5}
\def\ymin{-0.5} \def\ymax{3}
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax);
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\fill (0,0) circle (1pt) node[shift={(-135:2.5mm)}]{$O$};
\node at (current bounding box.south) [below=-2pt] {a) $\lim\limits_{x \rightarrow-\infty}\left[f(x)-(ax+b)\right]=0$};
\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[red,thick,smooth,samples=300,domain=\xmin:\xmax]
(-3.8,-0.6)..controls +(34:0.5) and +(180:.75)
..(-0.2,1.2)..controls +(0:0.75) and +(180:.75)
..(1,0.3)..controls +(0:0.5) and +(80:0)
..(2.2,1);
\draw[blue,smooth,samples=300,domain=\xmin:\xmax] plot(\x,{2/3*(\x)+2});
\path[blue] (-3,0)--(0,2)node[below,sloped,pos=1.3]{$y=ax+b$};
\path[red] (0.5,1)node[above right]{$y=f(x)$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Giới hạn âm vô cực bên phải x=a",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số minh họa lim(x→a⁺) f(x)=-∞, đường thẳng x=a là tiệm cận đứng bên phải.",
    ImagePath = "Tiem_can/Tiemcan9.png",
    Code = @"\begin{tikzpicture}[scale=.7,>=stealth, font=\footnotesize, line join=round, line cap=round]
%Hình d
\def\xmin{-2.2} \def\xmax{3.5}
\def\ymin{-2} \def\ymax{2} 
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax); 
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\fill (0,0) circle (1pt) node[shift={(-135:2.5mm)}]{$O$};
\draw (.6,\ymin)--(.6,\ymax)node[below right]{$x=a$};
\fill (.6,0) circle (1pt) node[shift={(-135:3mm)}]{$a$};
%\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[red] (0.7,-2)..controls +(85:0.2) and +(180:0.2)
..(1.2,-0.3)..controls +(0:0.2) and +(180:0.2)
..(1.7,-0.6)..controls +(0:0.4) and +(90:0)
..(2.5,2)
;
\node at (current bounding box.south) [below=-2pt] {d) $\lim\limits_{x \rightarrow a^{+}} f(x)=-\infty$}; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Giới hạn âm vô cực bên trái x=a",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số minh họa lim(x→a⁻) f(x)=-∞, đường thẳng x=a là tiệm cận đứng bên trái.",
    ImagePath = "Tiem_can/Tiemcan10.png",
    Code = @"\begin{tikzpicture}[scale=.7,>=stealth, font=\footnotesize, line join=round, line cap=round]
%Hình c
\def\xmin{-2.2} \def\xmax{3.5}
\def\ymin{-2} \def\ymax{2} 
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax); 
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\fill (0,0) circle (1pt) node[shift={(-45:2.5mm)}]{$O$};
\draw (2,\ymin)--(2,\ymax)node[below right]{$x=a$};
\fill (2,0) circle (1pt) node[shift={(-45:3mm)}]{$a$};
\path[red] (-2.25,1.2)node[below right]{$y=f(x)$};
%\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[red] (-2,1.4)..controls +(-10:-0.2) and +(-55:-.7)
..(1.3,0.65)..controls +(-50:0.4) and +(-90:0)
..(1.8,-2)
;
\node at (current bounding box.south) [below=-2pt] {c) $\lim\limits_{x \rightarrow a^{-}} f(x)=-\infty$}; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Giới hạn dương vô cực bên phải x=a",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số minh họa lim(x→a⁺) f(x)=+∞, đường thẳng x=a là tiệm cận đứng bên phải.",
    ImagePath = "Tiem_can/Tiemcan11.png",
    Code = @"\begin{tikzpicture}[scale=.7,>=stealth, font=\footnotesize, line join=round, line cap=round]
%Hình b
\def\xmin{-1.2} \def\xmax{4}
\def\ymin{-2} \def\ymax{2} 
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax); 
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\fill (0,0) circle (1pt) node[shift={(-45:2.5mm)}]{$O$};
\draw (1,\ymin)node[above right]{$x=a$}--(1,\ymax);
\fill (1,0) circle (1pt) node[shift={(-135:3mm)}]{$a$};
\path[red] (1.25,1)node[above right]{$y=f(x)$};
%\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[red] (1.2,2)..controls +(80:0) and +(0:-1.4)..(2.5,-0.8)
..controls +(0:0.1) and +(-80:-0.6)
..(3.5,-1.5);
\node at (current bounding box.south) [below=-2pt] {b) $\lim\limits_{x \rightarrow a^{+}} f(x)=+\infty$}; 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Đồ thị nồng độ thuốc có tiệm cận ngang",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số y=5-15t/(9t²+1) theo thời gian t, có tiệm cận ngang y=5, ứng dụng thực tế nồng độ thuốc.",
    ImagePath = "Tiem_can/Tiemcan12.png",
    Code = @"\begin{tikzpicture}[>=stealth,x=1cm,y=0.3cm,scale=1.5,font=\footnotesize]
\draw[->] (-0.5,0) -- (4,0) node[below] {$t$};
\draw[->] (0,-1) -- (0,6) node[left] {$y$};
\filldraw (0,0) circle (1pt)node[below left]{$O$};
\draw[domain=0:4,samples=200,red] plot (\x,{5-(15*(\x))/(9*(\x)^2+1)});
\draw[dashed] (0,5) node [left] {$5$}--(4,5);
\foreach \x/\g in {1/-90,2/-90,3/-90}
\draw[thin] (\x,2pt)--(\x,-2pt) + (\g:3mm) node {$\x$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Tiệm cận ngang khi x→-∞",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số có tiệm cận ngang y=m khi x→-∞, minh họa lim(x→-∞) f(x)=m.",
    ImagePath = "Tiem_can/Tiemcan13.png",
    Code = @"\begin{tikzpicture}[scale=1,>=stealth, font=\footnotesize, line join=round, line cap=round]
\def\xmin{-4} \def\xmax{2}
\def\ymin{-0.5} \def\ymax{3}
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax);
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\fill (0,0) circle (1pt) node[shift={(-135:2.5mm)}]{$O$};
\node at (current bounding box.south) [below=-2pt] {a) $\lim\limits_{x \rightarrow-\infty} f(x)=m$};
\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[red,thick,smooth,samples=300,domain=\xmin:\xmax]
(-4,0.9)..controls +(0:2) and +(180:0.5)
..(-1.5,0.5)..controls +(0:0.5) and +(180:0.5)
..(-0.3,1.4)..controls +(0:0.5) and +(135:1)
..(1.8,0.3);
\draw [blue](\xmin,1)--(\xmax,1);
\path[blue] (-3,1)node[above]{$y=m$};
\path[red] (0,1.3)node[above left]{$y=f(x)$};
\fill (0,1) circle (1pt) node[shift={(-135:3mm)}]{$m$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Tiệm cận ngang khi x→+∞",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số có tiệm cận ngang y=m khi x→+∞, minh họa lim(x→+∞) f(x)=m.",
    ImagePath = "Tiem_can/Tiemcan14.png",
    Code = @"\begin{tikzpicture}[scale=1,>=stealth, font=\footnotesize, line join=round, line cap=round]
\def\xmin{-1.5} \def\xmax{4}
\def\ymin{-0.5} \def\ymax{3}
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax);
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\fill (0,0) circle (1pt) node[shift={(-135:2.5mm)}]{$O$};
\node at (current bounding box.south) [below=-2pt] {b) $\lim\limits_{x \rightarrow+\infty} f(x)=m$};
\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[red,thick,smooth,samples=300,domain=\xmin:\xmax]
(-1,3)..controls +(-80:1) and +(170:1)
..(0.5,1.1)..controls +(170:-1) and +(180:-0.5)
..(3.9,0.8);
\draw [blue](\xmin,0.7)--(\xmax,0.7);
\path[blue] (4,0.7)node[below left]{$y=m$};
\path[red] (0.5,1)node[above right]{$y=f(x)$};
\fill (0,0.7) circle (1pt) node[shift={(-135:3mm)}]{$m$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Giới hạn dương vô cực bên trái x=a",
    Category = "Tiệm cận",
    Description = "Đồ thị hàm số minh họa lim(x→a⁻) f(x)=+∞, đường thẳng x=a là tiệm cận đứng bên trái.",
    ImagePath = "Tiem_can/Tiemcan15.png",
    Code = @"\begin{tikzpicture}[scale=.7,>=stealth, font=\footnotesize, line join=round, line cap=round]
%Hình a
\def\xmin{-2.2} \def\xmax{3.5}
\def\ymin{-2} \def\ymax{2} 
%\draw[color=gray!50,dashed] (\xmin,\ymin) grid (\xmax,\ymax); 
\draw[->] (\xmin,0)--(\xmax,0) node [below]{$x$};
\draw[->] (0,\ymin)--(0,\ymax) node [left]{$y$};
\fill (0,0) circle (1pt) node[shift={(-45:2.5mm)}]{$O$};
\draw (2.1,\ymin)--(2.1,\ymax)node[below right]{$x=a$};
\fill (2.1,0) circle (1pt) node[shift={(-45:3mm)}]{$a$};
%\clip (\xmin+0.1,\ymin+0.1) rectangle (\xmax-0.1,\ymax-0.1);
\draw[red] (-2,-1)..controls +(80:0.5) and +(0:-.5)..(-1,0.5)node[above]{$y=f(x)$}
..controls +(0:0.5) and +(180:0.5)..(0.5,-1.5)
..controls +(0:0.5) and +(87:-0.2)..(1.6,0)
..controls +(87:-.2) and +(90:-0.2)
..(2,1.85);
\node at (current bounding box.south) [below=-2pt] {a) $\lim\limits_{x \rightarrow a^{-}} f(x)=+\infty$};
\end{tikzpicture}"
},
