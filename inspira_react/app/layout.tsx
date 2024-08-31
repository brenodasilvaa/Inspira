import { AppBar, Toolbar, Typography, Button, Grid, Box, ThemeProvider } from "@mui/material"
import theme from "./theme"

export default function RootLayout({
  children,
}: {
  children: React.ReactNode
}) {
  return (
    <html lang="en">
      <body>
      <>
      <ThemeProvider theme={theme}>
      <AppBar position="absolute">
            <Toolbar>
              <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
                Inspira Music
              </Typography>
              <Button color="inherit">Login</Button>
            </Toolbar>
          </AppBar>
            <Box margin={2}>
                {children}
            </Box>

          <AppBar position="relative"  color="default">
            <Toolbar>
          <Typography variant="body2" color="textSecondary" align="center">
            © {new Date().getFullYear()} My Application. All rights reserved.
          </Typography>
         </Toolbar>
         </AppBar>
      </ThemeProvider>
        </>
      </body>
    </html>
  )
}