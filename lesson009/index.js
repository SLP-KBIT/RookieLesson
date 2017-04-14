'use strict';

/*
 * 変数の宣言．
 * const と let がある．
 * const は，再代入不可能
 * let は，再代入可能
 *
 * 関数の書き方．
 *
 * const hogeFunc = () => {
 *  // doSomething....
 * };
 *
 * 実行するとき
 * hogeFunc();
 *
 * java風にあえて表現すると
 * void function forEach(Function<T, Number> function);
 *
 **/

(function() {
  let orderCount = 0;

  const pieces = document.querySelectorAll('.piece');

  const generateMultipleArray = () => {
    const array = _.map(pieces, (element) => element.className.replace('piece',  '').trim())
    return _.chunk(array, 3);
  };

  const gameIsEnd = () => {
    const array = generateMultipleArray();
    // TODO: 3連の判定
    console.table(array);
    return false;
  };

  const onClick = (event) => {
    const className = event.target.className;
    const currentColor = orderCount % 2 === 0 ? ' black' : ' pink';
    const isEmpty = () => !/black/.test(className) && !/pink/.test(className);
    if (isEmpty()) {
      event.target.className += currentColor;
      orderCount++;
    }
    if (gameIsEnd()) {
      alert('ゲーム終了です！');
    }
  };
  pieces.forEach((piece) => {
    piece.addEventListener('click', onClick, false);
  });
})();
