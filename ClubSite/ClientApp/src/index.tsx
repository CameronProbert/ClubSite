// Types reference added to fix typescript error: Property 'hot' does not exist on type 'Module'
/// <reference types="webpack-env" />
import './assets/style/scss/site.scss';

import React from 'react';
import ReactDOM from 'react-dom';
import { AppContainer } from 'react-hot-loader';
import { ToastContainer, ToastPosition } from 'react-toastify';

import App from './App';

// This function starts up the React app when it runs in a browser. It sets up the routing configuration and injects the app into a DOM element.
const renderApp = (): void => {
    ReactDOM.render(
        <AppContainer>
            <>
                <App />
                <ToastContainer
                    autoClose={3500}
                    draggable={false}
                    newestOnTop={true}
                    position={ToastPosition.TOP_CENTER}
                    hideProgressBar
                />
            </>
        </AppContainer>,
        document.getElementById('root')
    );
};

// Execute function above to patch app to DOM
renderApp();
