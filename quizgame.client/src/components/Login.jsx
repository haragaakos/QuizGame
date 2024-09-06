import useNavigate from 'react-router-dom'
import { TextField, Button, Box, Card, CardContent, Typography } from '@mui/material';
import Center from './Center';
import useForm from '../hooks/useForm';
import { ENDPOINTS, createApiEndpoint } from '../api/Index';
import useStateContext from '../hooks/useStateContext';

const getFreshModel = () => ({
    name: '',
    email:''
})

export default function Login() {

    const { context, setContext } = useStateContext();
    const navigate = useNavigate();

    const {
        values,
        setValues,
        errors,
        setErrors,
        handleInputChange
    } = useForm(getFreshModel);

    const login = e => {
        e.preventDefault();
        if (validate()) createApiEndpoint(ENDPOINTS.users)
            .post(values)
            .then(response => {
                setContext({ id: response.data.id })
                navigate('/quiz')
                
            })
            .catch(error => console.log(error))
    }

    const validate = () => {
        let temp = {}
        temp.email = (/\S+@\S+\.\S+/).test(values.email) ? "" : "Helytelen Email cím formátum!"
        temp.name = values.name != "" ? "" : "A mező kitöltése kötelező!"
        setErrors(temp)
        return Object.values(temp).every(x=>x==="")
    }

    return (
        <Center>
            {context.id }
            <Card sx={{width:400} }>
                <CardContent sx={{textAlign:'center'} }>
                    <Typography variant="h3" sx={{ my: 3 }}>
                    KvízJáték
                    </Typography>
         <Box sx={{
            '& .MuiTextField-root':{
                m: 1,
                width:90
            }
        }}>
                 <form noValidate autoComplete="off" onSubmit={login}>
                <TextField
                    label="Email"
                    name="email"
                    value={values.email}
                    onChange={handleInputChange }
                                variant="outlined"
                                {...(errors.email && { error: true, helperText: errors.email })} 
                />
                <TextField
                                label="Név"
                                name="name"
                                value={values.name}
                                onChange={handleInputChange}
                                variant="outlined"
                                {...(errors.name && {error:true, helperText: errors.name}) }    
                />
                <Button
                    type="submit"
                    variant="contained"
                    size="large"
                    sx={{width:90} }>Start
                </Button>
            </form>
                    </Box>
                </CardContent>
            </Card>
        </Center>
        )
}