import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import './index.css'
import { createTheme, ThemeProvider } from '@mui/material/styles'
import CssBaseline from '@mui/material/CssBaseline';
import ContextProvider from './hooks/useStateContext.jsx'


const darkTheme = createTheme({
    palette: {
        mode: 'dark',
    }
})

ReactDOM.createRoot(document.getElementById('root')).render(
    <React.StrictMode>
        <ContextProvider>
        <ThemeProvider theme={darkTheme}>
            <CssBaseline></CssBaseline>
            <App />
        </ThemeProvider>
        </ContextProvider>   
  </React.StrictMode>,
)
