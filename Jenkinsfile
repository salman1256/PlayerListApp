pipeline
{
    agent any
    environment {
        DOTNET_CLI_HOME="${WORKSPACE}/.dotnet"
    }
    stages
    {
        stage('Checkout')
        {
            steps
            {
                git 'https://github.com/salman1256/PlayerListApp.git'
                echo 'check out done'
            }
            
        }
        stage('Restore')
        {
            steps
            { 
                bat 'cd ./PlayerList && dotnet restore'
                echo 'Packages restore'
            }
            
        }
         stage('Build')
        {
            steps
            {
                 bat 'cd ./PlayerList && dotnet build'
                echo 'Build Done'
            }
            
        }
         stage('Test')
        {
            steps
            {
                bat 'cd ./PlayerList.Tests && dotnet test --no-build --verbosity normal'
                echo 'Build Done'
            }
            
        }
         stage('Run')
        {
            steps
            {
                 bat 'cd ./PlayerList && dotnet run'
                echo 'Build Done'
            }
            
        }
    }
    
}