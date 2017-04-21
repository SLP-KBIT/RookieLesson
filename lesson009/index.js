'use strict';

const FIELD_SIZE = 3;
const LEN_SIZE = 3;

(function() {
  let orderCount = 0;

  const pieces = document.querySelectorAll('.piece');

  const generateMultipleArray = () => {
    const array = _.map(pieces, (element) => element.className.replace('piece',  '').trim())
    return _.chunk(array, FIELD_SIZE);
  };

  const isEmpty = (str) => str === '';

  const gameIsEnd = () => {
    const array = generateMultipleArray();
    let flag = false;
    _.times(array.length).forEach(i => {
      const line = array[i];
      _.times(line.length).forEach(j => {
        const cell = array[i][j];
        _.times(3, (x) => x - 1).forEach(dx => {
          _.times(3, (y) => y - 1).forEach(dy => {
            let count = 0;
            _.times(LEN_SIZE + 1).forEach(k => {
              const color = _.get(array, [i + dx + k, j + dy + k], '');
              if (!isEmpty(color) && color === cell) count++;
              if (count === LEN_SIZE) flag = true;
            });
          });
        });
      });
    });
    console.table(array);
    return flag;
  };

  const onClick = (event) => {
    const className = event.target.className;
    const currentColor = orderCount % 2 === 0 ? ' black' : ' pink';
    const isEmptyColor = () => !/black/.test(className) && !/pink/.test(className);
    if (isEmptyColor()) {
      event.target.className += currentColor;
      orderCount++;
    }
    if (gameIsEnd()) {
      const resultElement = document.querySelector('.result');
      resultElement.innerText = 'ゲーム終了';
    }
  };
  pieces.forEach((piece) => {
    piece.addEventListener('click', onClick, false);
  });
})();
