var onBtnClick = function (t, opts) {
    t.modal({
        url: './Modal.html',
        accentColor: '#F2D600',
        fullscreen: true,
        title: 'Story Map'
    })
};

window.TrelloPowerUp.initialize({
    'board-buttons': function (t, opts) {
        return [{
            text: 'Story Map',
            callback: onBtnClick,
            condition: 'always'
        }];
    }
});