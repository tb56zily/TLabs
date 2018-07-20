/*the container must be positioned relative:*/

.menu-bar {
    height: 30px;
    width: 100%;
    background-color: green;
}

.quote-tile-container {
    display: inline-block;
    width: max-content;
    position: relative;
}

.button {
    border: none;
    color: white;
    text-decoration: none;
    font-size: 16px;
    margin: 2px 2px;
    cursor: pointer;
}

.new-tile-button {
    padding: 4px 8px;
    text-align: center;
    background-color: #4CAF50;
}

.close-tile-button {
    background-color: red;
    padding: 1px 1px 1px;
    width: 5%;
    height: 20px;
    right: 0;
}

.stream-quote-tile {
    position: relative;
    margin-top: 50px;
    width: 280px;
    height: 339px;
    border: 1px ;
    border-radius: 1px 1px 4px 4px;
    overflow: hidden;
    font-family: Serif;
    font-size: 20px;
    font-weight: 500;
    color: #2c3e50;
    box-shadow: 0 10px 26px -7px rgba(121, 135, 150, .5);
    user-select: none;
}

.stream-quote-tile, .currency-select, .action-prices-container {
    box-sizing: border-box;
    text-align: center;
}

.currency-container {
    height: 40px;
    background-color: darkgray;
}

.currency-select {
    position: absolute;
    height: inherit;
    overflow: hidden;
    width: 50%;

}

.base-currency-select {
    border-right: 1px solid #c6c6c6;
    position: absolute;
}

.quote-currency-select {
    right: 0;
    border-left: 1px solid #c6c6c6;
    position: absolute;
}

.currency-select select {
    padding: 5px 8px;
    width: 100%;
    height: 100%;
    border: none;
    -webkit-appearance: none;
}

.currency-select select:focus {
    outline: none;
}

.action-prices-container {
    text-align: center;
    border-top: 2px solid #2b92b6;
    background-color: #f4f6f9;
    height: 35px;
    line-height: 30px;
}

.action-side {
    height: inherit;
    font-size: 13px;
    font-weight: 300;
    padding-top: 2px;
    width: 50%;
}

.sell-action-side {
    position: absolute;
    left: 0;
}

.buy-action-side {
    position: absolute;
    right: 0;
}

.action-side, .price {
    display: inline-block;
}

.action-prices-container, .prices-container {
    border-bottom: 1px solid #b9c5d2;
}

.prices-container {
    position: relative;
    background-color: forestgreen;
}

.prices-container:first-child {
    border-right: 1px solid #c6c6c6;
}

.price {
    text-align: center;
    font-size: 30px;
    height: 100px;
    margin: 4px 0 0;
    position: relative;
}

.price-1 {
    font-size: 15px;
    color: #2c3e50;
    top: 4px;
    text-align: center;
}

.price-2 {
    color: #2c3e50;
    top: 10px;
    font-size: 50px;
    font-weight: 400
}

.tooltip {
    position: relative;
    display: inline-block;
    border-bottom: 1px;
}

.tooltip .tooltiptext {
    visibility: hidden;
    width: max-content;
    height: 20px;
    color: #2b92b6;
    padding: 10px;
    text-align: center;
    border-radius: 3px;
    /* Position the tooltip */
    position: absolute;
    z-index: 1;
}

.tooltip:hover .tooltiptext {
    visibility: visible;
}
