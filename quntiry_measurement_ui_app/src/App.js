import React from 'react';
import './App.css';
import { BrowserRouter, Route, Switch, withRouter } from 'react-router-dom';
import Length from './Pages/Length';
import Temprature from './Pages/Temprature';
import Weight from './Pages/Weight';
import { QuantityRow } from './component/QuantityRow';
import Head from './Pages/Head';

function App() {
  const Menu = withRouter(QuantityRow);
  return (
    <div className="App">
      <div className="optionColor">
        <h1>Quantity Measurment</h1>
        <BrowserRouter>
        <Menu/>
      <div>
        <Switch>
          <Route path='/' component={Head} exact/>
        <Route path='/Length' component={Length} exact />
        <Route path='/Weight' component={Weight} exact />
        <Route path='/Temprature' component={Temprature} exact/>
        </Switch>
      </div>
    </BrowserRouter>  
      </div>
    </div>
  );
}
export default App;