pipeline {
    agent any

    stages {
        stage('Restore') {
            steps { sh 'dotnet restore ci.sln' }
        }
        stage('Build') {
            steps { sh 'dotnet build ci.sln --no-restore' }
        }
        stage('Test') {
            steps { sh 'dotnet test ci.sln --no-build' }
        }
    }
}