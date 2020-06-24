import React from 'react';
import { Redirect, Route } from 'react-router-dom';
const AppRoute = ({ component: Component, ...rest }) => {

  return (
    <Route
          {...rest}
          /*
      render={props =>
        isLoggedIn ? (
          <Component {...props} />
        ) : (
          <Redirect to={{ pathname: '/', state: { from: props.location } }} />
        )
      }
      */
    />
  )
}

export default AppRoute