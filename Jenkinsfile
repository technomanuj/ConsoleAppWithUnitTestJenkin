pipeline{
        agent any
        
        stages{
            stage('Begin')
            {
                steps{
                    echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
                }
            }
            stage('GitCheckout'){
                steps{
                    git poll:false, url:'https://github.com/technomanuj/ConsoleAppWithUnitTestJenkin.git'
                }
            }
            stage('Build'){
                steps{
                    bat 'dotnet build consoleappjenkin1.sln'
                }
            }
            stage('ExecuteCode'){
              
                  steps{
                     
                    bat 'dotnet run --project C#ConsoleAppForJenkin1/C#ConsoleAppForJenkin1.csproj' 
                      }
            }
            
            stage('Test'){
                steps{
                    bat 'dotnet test --filter ConsoleAppForJenkin1Test.UnitTest1  ConsoleAppForJenkin1Test/ConsoleAppForJenkin1Test.csproj'
                }
            }
        }
        
        post{
            always{
                echo "All parts were executed"
            }
            
            failure{
                echo 'there is an error'
            }
             
            success{
                echo 'All code was executed successfully'
            }
        }
}